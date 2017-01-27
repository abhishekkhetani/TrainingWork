using System;
using System.Linq;
using System.Web.UI;
using Telerik.Sitefinity.Web.UI;
using Telerik.Sitefinity.Web.UI.ControlDesign;
using System.Collections.Generic;

namespace SitefinityWebApp.WidgetDesigners.Skills
{
    /// <summary>
    /// Represents a designer for the <typeparamref name="SitefinityWebApp.Mvc.Controllers.SkillsController"/> widget
    /// </summary>
    public class SkillsDesigner : ControlDesignerBase
    {
        #region Properties
        /// <summary>
        /// Obsolete. Use LayoutTemplatePath instead.
        /// </summary>
        protected override string LayoutTemplateName
        {
            get
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the layout template's relative or virtual path.
        /// </summary>
        public override string LayoutTemplatePath
        {
            get
            {
                if (string.IsNullOrEmpty(base.LayoutTemplatePath))
                    return SkillsDesigner.layoutTemplatePath;
                return base.LayoutTemplatePath;
            }
            set
            {
                base.LayoutTemplatePath = value;
            }
        }

        protected override HtmlTextWriterTag TagKey
        {
            get
            {
                return HtmlTextWriterTag.Div;
            }
        }
        #endregion

        #region Control references
        /// <summary>
        /// Gets the control that is bound to the TxtSkill_1 property
        /// </summary>
        protected virtual Control TxtSkill_1
        {
            get
            {
                return this.Container.GetControl<Control>("TxtSkill_1", true);
            }
        }
        /// <summary>
        /// Gets the control that is bound to the TxtPer_1 property
        /// </summary>
        protected virtual Control TxtPer_1
        {
            get
            {
                return this.Container.GetControl<Control>("TxtPer_1", true);
            }
        }

        /// <summary>
        /// Gets the control that is bound to the TxtSkill_2 property
        /// </summary>
        protected virtual Control TxtSkill_2
        {
            get
            {
                return this.Container.GetControl<Control>("TxtSkill_2", true);
            }
        }
        /// <summary>
        /// Gets the control that is bound to the TxtPer_2 property
        /// </summary>
        protected virtual Control TxtPer_2
        {
            get
            {
                return this.Container.GetControl<Control>("TxtPer_2", true);
            }
        }

        /// <summary>
        /// Gets the control that is bound to the TxtSkill_3 property
        /// </summary>
        protected virtual Control TxtSkill_3
        {
            get
            {
                return this.Container.GetControl<Control>("TxtSkill_3", true);
            }
        }
        /// <summary>
        /// Gets the control that is bound to the TxtPer_3 property
        /// </summary>
        protected virtual Control TxtPer_3
        {
            get
            {
                return this.Container.GetControl<Control>("TxtPer_3", true);
            }
        }

        /// <summary>
        /// Gets the control that is bound to the TxtSkill_4 property
        /// </summary>
        protected virtual Control TxtSkill_4
        {
            get
            {
                return this.Container.GetControl<Control>("TxtSkill_4", true);
            }
        }
        /// <summary>
        /// Gets the control that is bound to the TxtPer_4 property
        /// </summary>
        protected virtual Control TxtPer_4
        {
            get
            {
                return this.Container.GetControl<Control>("TxtPer_4", true);
            }
        }


        #endregion

        #region Methods
        protected override void InitializeControls(Telerik.Sitefinity.Web.UI.GenericContainer container)
        {
            // Place your initialization logic here
        }
        #endregion

        #region IScriptControl implementation
        /// <summary>
        /// Gets a collection of script descriptors that represent ECMAScript (JavaScript) client components.
        /// </summary>
        public override System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> GetScriptDescriptors()
        {
            var scriptDescriptors = new List<ScriptDescriptor>(base.GetScriptDescriptors());
            var descriptor = (ScriptControlDescriptor)scriptDescriptors.Last();

            descriptor.AddElementProperty("message", this.TxtSkill_1.ClientID);

            return scriptDescriptors;
        }

        /// <summary>
        /// Gets a collection of ScriptReference objects that define script resources that the control requires.
        /// </summary>
        public override System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> GetScriptReferences()
        {
            var scripts = new List<ScriptReference>(base.GetScriptReferences());
            scripts.Add(new ScriptReference(SkillsDesigner.scriptReference));
            return scripts;
        }
        #endregion

        #region Private members & constants
        public static readonly string layoutTemplatePath = "~/WidgetDesigners/Skills/SkillsDesigner.ascx";
        public const string scriptReference = "~/WidgetDesigners/Skills/SkillsDesigner.js";
        #endregion
    }
}
 
