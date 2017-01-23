using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using Telerik.Sitefinity.DynamicModules;
using Telerik.Sitefinity.Utilities.TypeConverters;
using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.Taxonomies;
using Telerik.Sitefinity.Taxonomies.Model;
using Telerik.Sitefinity.Modules.Libraries;
using Telerik.Sitefinity.Data;
using Telerik.Sitefinity.Versioning;
using System.Collections.Generic;
using Telerik.Sitefinity.Data.Linq.Dynamic;
using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.Modules.Libraries;
using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.DynamicModules;
using Telerik.Sitefinity.Libraries.Model;
using Telerik.Sitefinity.RelatedData;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Recent", Title = "Recent", SectionName = "MvcWidgets"), Telerik.Sitefinity.Web.UI.ControlDesign.ControlDesigner(typeof(SitefinityWebApp.WidgetDesigners.Recent.RecentDesigner))]
    public class RecentController : Controller
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [Category("String Properties")]
        public string Message { get; set; }
        public string Title { get; set; }
        public string Portfolio_Name { get; set; }
        public string Portfolio_Photo_Path { get; set; }
        public string Portfolio_Description { get; set; }

        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            var model = new RecentModel();
            if (string.IsNullOrEmpty(this.Message))
            {
                model.Message = "Hello, World!";
            }
            else
            {
                model.Message = this.Message;
            }

            //Recent Portfolios

            // Set the provider name for the DynamicModuleManager here. All available providers are listed in
            // Administration -> Settings -> Advanced -> DynamicModules -> Providers
            var providerName = String.Empty;

            // Set a transaction name
            var transactionName = "someTransactionName";

            DynamicModuleManager dynamicModuleManager = DynamicModuleManager.GetManager(providerName, transactionName);
            Type abhishekkhetaniType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.Portfolio.abhishekkhetani");

            //var abhishekkhetaniItem = dynamicModuleManager.GetDataItems(abhishekkhetaniType);
            
            TaxonomyManager taxonomyManager = TaxonomyManager.GetManager();
            var categories = taxonomyManager.GetTaxa<HierarchicalTaxon>().Where(t => t.Taxonomy.Name == "Categories").ToList();

            var category = categories.Where(x => x.Title == "Techonology").FirstOrDefault();
   
            List<RecentModel> recentModel = new List<RecentModel>();
            if (category != null)
            {
                var myCollection = dynamicModuleManager.GetDataItems(abhishekkhetaniType).Where("Category.Contains((" + category.Id.ToString() + "))").ToList().Distinct();
                myCollection = myCollection.Where(d => d.Status == Telerik.Sitefinity.GenericContent.Model.ContentLifecycleStatus.Live && d.Visible == true);

                foreach (var getPortfolio in myCollection)
                {
                    RecentModel rTempModel = new RecentModel();
                    rTempModel.Title = getPortfolio.GetValue("Title").ToString();
                    rTempModel.Portfolio_Description = getPortfolio.GetValue("Description").ToString();
                    //rTempModel.Portfolio_Photo_Path = getPortfolio.UrlName.ToString();

                    var tempImage = getPortfolio.GetRelatedItems<Image>("Image").SingleOrDefault();

                    rTempModel.Portfolio_Photo_Path = tempImage.MediaUrl;
                    recentModel.Add(rTempModel);
                    
                    rTempModel = null;
                }   
            }
            //ViewBag.Recent = recentModel.ToList();
            return View("Default", recentModel);
        }


    }
}