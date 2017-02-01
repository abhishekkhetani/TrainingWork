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
        public string Skill_1 { get; set; }
        public string Percentage_1 { get; set; }
        public string Skill_2 { get; set; }
        public string Percentage_2 { get; set; }
        public string Skill_3 { get; set; }
        public string Percentage_3 { get; set; }
        public string Skill_4 { get; set; }
        public string Percentage_4 { get; set; }

        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            var model = new SkillsModel();

            if (this.Skill_1 != null)
            {
                model.Skill_1 = this.Skill_1;
                model.Percentage_1 = this.Percentage_1;
            }
            else
            {
                model.Skill_1 = "C#";
                model.Percentage_1 = "90";
            }

            if (this.Skill_2 != null)
            {
                model.Skill_2 = this.Skill_2;
                model.Percentage_2 = this.Percentage_2;
            }
            else
            {
                model.Skill_2 = "C#";
                model.Percentage_2 = "90";
            }

            if (this.Skill_3 != null)
            {
                model.Skill_3 = this.Skill_3;
                model.Percentage_3 = this.Percentage_3;
            }
            else
            {
                model.Skill_3 = "C#";
                model.Percentage_3 = "90";
            }
            if (this.Skill_4 != null)
            {
                model.Skill_4 = this.Skill_4;
                model.Percentage_4 = this.Percentage_4;
            }
            else
            {
                model.Skill_4 = "C#";
                model.Percentage_4 = "90";
            }

            return View("Default", model);
        }
    }
}