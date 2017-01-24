using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using Telerik.Sitefinity.DynamicModules;
using Telerik.Sitefinity.Utilities.TypeConverters;
using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.Model;
using System.Collections.Generic;
using Telerik.Sitefinity.Libraries.Model;
using Telerik.Sitefinity.RelatedData;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Testimonial", Title = "Testimonial", SectionName = "MvcWidgets"), Telerik.Sitefinity.Web.UI.ControlDesign.ControlDesigner(typeof(SitefinityWebApp.WidgetDesigners.Testimonial.TestimonialDesigner))]
    public class TestimonialController : Controller
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [Category("String Properties")]
        public string Message { get; set; }
        public string Client_Name { get; set; }
        public string Designation { get; set; }
        public string Description { get; set; }
        public string Image_Path { get; set; }

        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            var model = new TestimonialModel();
            if (string.IsNullOrEmpty(this.Message))
            {
                model.Message = "Hello, World!";
            }
            else
            {
                model.Message = this.Message;
            }

            // Get Testimonial Data

            // Set the provider name for the DynamicModuleManager here. All available providers are listed in
            // Administration -> Settings -> Advanced -> DynamicModules -> Providers
            var providerName = String.Empty;

            // Set a transaction name
            var transactionName = "someTransactionName";

            DynamicModuleManager dynamicModuleManager = DynamicModuleManager.GetManager(providerName, transactionName);
            Type clientTestimonialType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.ClientTestimonial.ClientTestimonial");
            
            // This is how we get the collection of Client Testimonial items
            var myCollection = dynamicModuleManager.GetDataItems(clientTestimonialType);
            myCollection = myCollection.Where(d => d.Status == Telerik.Sitefinity.GenericContent.Model.ContentLifecycleStatus.Live && d.Visible == true);
            List<TestimonialModel> testimonialModel = new List<TestimonialModel>();

            foreach (var getTestimonial in myCollection)
            {
                TestimonialModel tTempModel = new TestimonialModel();

                tTempModel.Client_Name = getTestimonial.GetValue("Name").ToString();
                tTempModel.Designation = getTestimonial.GetValue("Designation").ToString();
                tTempModel.Description = getTestimonial.GetValue("Description").ToString();

                var tempImage = getTestimonial.GetRelatedItems<Image>("Image").SingleOrDefault();

                tTempModel.Image_Path = tempImage.MediaUrl;

                testimonialModel.Add(tTempModel);

                tTempModel = null;
            }

            return View("Default", testimonialModel);
        }
    }
}