using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using Telerik.Sitefinity.Taxonomies;
using Telerik.Sitefinity.Taxonomies.Model;
using System.Collections.Generic;
using Telerik.Sitefinity.DynamicModules;
using Telerik.Sitefinity.Utilities.TypeConverters;
using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.Libraries.Model;
using Telerik.Sitefinity.RelatedData;
using Telerik.Sitefinity.Modules.Libraries;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Categories", Title = "Categories", SectionName = "MvcWidgets")]
    public class CategoriesController : Controller
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [Category("String Properties")]
        public string Message { get; set; }
        public List<string>Category_Name { get; set; }
        public string Portfolio_Name { get; set; }
        public string Portfolio_Photo_Path { get; set; }
        public string Portfolio_Description { get; set; }

        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            var model = new CategoriesModel();
            if (string.IsNullOrEmpty(this.Message))
            {
                model.Message = "Hello, World!";
            }
            else
            {
                model.Message = this.Message;
            }

            // Get Categories
            //var taxonomyMgr = TaxonomyManager.GetManager();
            
            //HierarchicalTaxonomy category = taxonomyMgr.GetTaxonomies<HierarchicalTaxonomy>().Where(x => x.Name == "Categories").SingleOrDefault();
           
            TaxonomyManager taxonomyManager = TaxonomyManager.GetManager();
            var categories = taxonomyManager.GetTaxa<HierarchicalTaxon>().Where(t => t.Taxonomy.Name == "Categories").ToList();

            List<CategoriesModel> CategoriesListModel = new List<CategoriesModel>();
            CategoriesModel categoriesModel = new CategoriesModel();
            List<string> cat = new List<string>();
            foreach(var temp in categories){
                cat.Add(temp.Title);
            }
            ViewBag.Categories = cat.ToList().ConvertAll(d => d.ToLower());
            
            //Get Portfolio 

            // Set the provider name for the DynamicModuleManager here. All available providers are listed in
            // Administration -> Settings -> Advanced -> DynamicModules -> Providers
            var providerName = String.Empty;

            // Set a transaction name
            var transactionName = "someTransactionName";

            DynamicModuleManager dynamicModuleManager = DynamicModuleManager.GetManager(providerName, transactionName);
            Type abhishekkhetaniType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.Portfolio.abhishekkhetani");


            if (categories != null)
            {
                var myCollection = dynamicModuleManager.GetDataItems(abhishekkhetaniType).ToList().Distinct();
                myCollection = myCollection.Where(d => d.Status == Telerik.Sitefinity.GenericContent.Model.ContentLifecycleStatus.Live && d.Visible == true);

                foreach (var getPortfolio in myCollection)
                {
                    CategoriesModel cTempModel = new CategoriesModel();
                    //var tempCat = getPortfolio.GetValue("Category").
                    cTempModel.Category_Name = new List<string>();
                    IList<Guid> categoryIds = (IList<Guid>)getPortfolio.GetValue("Category");

                    foreach (Guid diffCat in categoryIds)
                    {

                        //Guid firstCategoryId = categoryIds.FirstOrDefault();

                        if (Guid.Empty != diffCat)
                        {
                            string tempName = taxonomyManager.GetTaxon<HierarchicalTaxon>(diffCat).Name.ToLower();
                            
                            cTempModel.Category_Name.Add(tempName);
                        } 
                    }


                    cTempModel.Portfolio_Name = getPortfolio.GetValue("Title").ToString();
                    cTempModel.Portfolio_Description = getPortfolio.GetValue("Description").ToString();
                    //cTempModel.Portfolio_Photo_Path = getPortfolio.UrlName.ToString();

                    var tempImage = getPortfolio.GetRelatedItems<Image>("Image").SingleOrDefault();

                    cTempModel.Portfolio_Photo_Path = tempImage.MediaUrl;
                    CategoriesListModel.Add(cTempModel);

                    cTempModel = null;
                }
            }


            //Get Images with Categories name
            LibrariesManager librariesManager = LibrariesManager.GetManager();

            var images = librariesManager.GetImages().ToList();



            return View("Default", CategoriesListModel);
        }
    }
}