#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36366
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.MultipleChoiceField
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 4 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/MultipleChoiceField/Write.Default_Inline.cshtml")]
    public partial class Write_Default_Inline : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.MultipleChoiceField.MultipleChoiceFieldViewModel>
    {
        public Write_Default_Inline()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 8 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 10 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
  
    var fieldName = string.IsNullOrEmpty(Model.MetaField.FieldName) ? "multiple-choice-field-name" : Model.MetaField.FieldName;
    var requiredAttributes = MvcHtmlString.Create(Model.ValidationAttributes);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 564), Tuple.Create("\"", 598)
            
            #line 15 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 572), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 572), false)
, Tuple.Create(Tuple.Create(" ", 587), Tuple.Create("form-group", 588), true)
);

WriteLiteral(" data-sf-role=\"multiple-choice-field-container\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 707), Tuple.Create("\'", 763)
, Tuple.Create(Tuple.Create("", 715), Tuple.Create("{", 715), true)
, Tuple.Create(Tuple.Create(" ", 716), Tuple.Create("\"required\":", 717), true)
, Tuple.Create(Tuple.Create(" ", 728), Tuple.Create("\"", 729), true)
            
            #line 16 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
  , Tuple.Create(Tuple.Create("", 730), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 730), false)
, Tuple.Create(Tuple.Create("", 761), Tuple.Create("\"}", 761), true)
);

WriteLiteral(" />\r\n        <strong>");

            
            #line 17 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
           Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n");

            
            #line 18 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        
            
            #line default
            #line hidden
            
            #line 18 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
         if (!string.IsNullOrEmpty(Model.MetaField.Description)) 
        {

            
            #line default
            #line hidden
WriteLiteral("           <p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 20 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                            Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 21 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 22 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
         foreach (var choice in Model.Choices)
        {
            var selctedAttributes = !Model.IsRequired && choice == Model.MetaField.DefaultValue as string ? "checked" : string.Empty;

            
            #line default
            #line hidden
WriteLiteral("            <label");

WriteLiteral(" class=\"radio-inline\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1245), Tuple.Create("\"", 1262)
            
            #line 26 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1252), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 1252), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 1263), Tuple.Create("\"", 1278)
            
            #line 26 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1271), Tuple.Create<System.Object, System.Int32>(choice
            
            #line default
            #line hidden
, 1271), false)
);

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral(" ");

            
            #line 26 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                            Write(selctedAttributes);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 26 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                               Write(requiredAttributes);

            
            #line default
            #line hidden
WriteLiteral(" />\r\n");

WriteLiteral("                ");

            
            #line 27 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
           Write(choice);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </label>\r\n");

            
            #line 29 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 31 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        
            
            #line default
            #line hidden
            
            #line 31 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
         if(Model.HasOtherChoice)
        {
           

            
            #line default
            #line hidden
WriteLiteral("            <label");

WriteLiteral(" class=\"radio-inline\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1562), Tuple.Create("\"", 1579)
            
            #line 35 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1569), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 1569), false)
);

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-radio\"");

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral("/>\r\n");

WriteLiteral("                ");

            
            #line 36 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
           Write(Html.Resource("Other"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </label>\r\n");

WriteLiteral("            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-text\"");

WriteLiteral(" />\r\n");

            
            #line 39 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
            
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n\r\n");

            
            #line 44 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/MultipleChoiceField/multiple-choice-field.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
