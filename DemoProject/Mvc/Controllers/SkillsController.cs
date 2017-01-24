using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using Telerik.Sitefinity.DynamicModules;
using Telerik.Sitefinity.Utilities.TypeConverters;
using System.Collections.Generic;
using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.Model;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Skills", Title = "Skills", SectionName = "MvcWidgets"), Telerik.Sitefinity.Web.UI.ControlDesign.ControlDesigner(typeof(SitefinityWebApp.WidgetDesigners.Skills.SkillsDesigner))]
    public class SkillsController : Controller
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [Category("String Properties")]
        public string Message { get; set; }
        public string SkillName { get; set; }
        public string Percentage { get; set; }

        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            var model = new SkillsModel();
            if (string.IsNullOrEmpty(this.Message))
            {
                model.Message = "Hello, World!";
            }
            else
            {
                model.Message = this.Message;
            }

            // Get Skills Data
            // Set the provider name for the DynamicModuleManager here. All available providers are listed in
            // Administration -> Settings -> Advanced -> DynamicModules -> Providers
            var providerName = String.Empty;

            // Set a transaction name
            var transactionName = "someTransactionName";

            DynamicModuleManager dynamicModuleManager = DynamicModuleManager.GetManager(providerName, transactionName);
            Type skillsType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.Skill.skills");

            // This is how we get the collection of Services items
            var myCollection = dynamicModuleManager.GetDataItems(skillsType).ToList().Distinct();
            myCollection = myCollection.Where(d => d.Status == Telerik.Sitefinity.GenericContent.Model.ContentLifecycleStatus.Live && d.Visible == true);
            List<SkillsModel> servicesModel = new List<SkillsModel>();

            foreach (var getSkill in myCollection)
            {
                SkillsModel sTempModel = new SkillsModel();

                sTempModel.SkillName = getSkill.GetValue("Skill").ToString();
                sTempModel.Percentage = getSkill.GetValue("Percentage").ToString();
              
                servicesModel.Add(sTempModel);

                sTempModel = null;
            }

            return View("Default", servicesModel);
        }
    }
}