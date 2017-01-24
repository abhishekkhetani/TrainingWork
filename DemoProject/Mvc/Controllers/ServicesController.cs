using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using Telerik.Sitefinity.DynamicModules;
using Telerik.Sitefinity.Utilities.TypeConverters;
using System.Collections.Generic;
using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.Libraries.Model;
using Telerik.Sitefinity.RelatedData;
namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Services", Title = "Services", SectionName = "MvcWidgets"), Telerik.Sitefinity.Web.UI.ControlDesign.ControlDesigner(typeof(SitefinityWebApp.WidgetDesigners.Services.ServicesDesigner))]
    public class ServicesController : Controller
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [Category("String Properties")]
        public string Message { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Photo_Path { get; set; }

        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            var model = new ServicesModel();
            if (string.IsNullOrEmpty(this.Message))
            {
                model.Message = "Hello, World!";
            }
            else
            {
                model.Message = this.Message;
            }

            // Get Services Data

            // Set the provider name for the DynamicModuleManager here. All available providers are listed in
            // Administration -> Settings -> Advanced -> DynamicModules -> Providers
            var providerName = String.Empty;

            // Set a transaction name
            var transactionName = "someTransactionName";

            DynamicModuleManager dynamicModuleManager = DynamicModuleManager.GetManager(providerName, transactionName);
            Type abhishekkhetaniType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.Services.abhishekkhetani");
            
            // This is how we get the collection of Services items
            var myCollection = dynamicModuleManager.GetDataItems(abhishekkhetaniType).ToList().Distinct(); 
            myCollection = myCollection.Where(d => d.Status == Telerik.Sitefinity.GenericContent.Model.ContentLifecycleStatus.Live && d.Visible == true);
            List<ServicesModel> servicesModel = new List<ServicesModel>();

            foreach (var getService in myCollection)
            {
                ServicesModel sTempModel = new ServicesModel();

                sTempModel.Title = getService.GetValue("Title").ToString();
                sTempModel.Description = getService.GetValue("Description").ToString();
                //sTempModel.Description = getService.GetValue("URL").ToString();
                //sTempModel.Photo_Path = getService.GetValue<Image>("Image").MediaUrl;
                
                //getting some dynamic item
                //DynamicContent pressReleaseItem = getService.First();
                
                var tempImage = getService.GetRelatedItems<Image>("Image").SingleOrDefault();
                
                sTempModel.Photo_Path = tempImage.MediaUrl;
                
                servicesModel.Add(sTempModel);

                sTempModel = null;
            }

            return View("Default", servicesModel);
        }
    }
}