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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.ParagraphTextField
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
    
    #line 4 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/ParagraphTextField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.ParagraphTextField.ParagraphTextFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 8 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 344), Tuple.Create("\"", 378)
, Tuple.Create(Tuple.Create("", 352), Tuple.Create("form-group", 352), true)
            
            #line 10 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create(" ", 362), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 363), false)
);

WriteLiteral(" data-sf-role=\"paragraph-text-field-container\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 486), Tuple.Create("\'", 589)
, Tuple.Create(Tuple.Create("", 494), Tuple.Create("{\"maxLength\":\"", 494), true)
            
            #line 11 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
 , Tuple.Create(Tuple.Create("", 508), Tuple.Create<System.Object, System.Int32>(Model.MaxLengthViolationMessage
            
            #line default
            #line hidden
, 508), false)
, Tuple.Create(Tuple.Create("", 540), Tuple.Create("\",", 540), true)
, Tuple.Create(Tuple.Create(" ", 542), Tuple.Create("\"required\":", 543), true)
, Tuple.Create(Tuple.Create(" ", 554), Tuple.Create("\"", 555), true)
            
            #line 11 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                 , Tuple.Create(Tuple.Create("", 556), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 556), false)
, Tuple.Create(Tuple.Create("", 587), Tuple.Create("\"}", 587), true)
);

WriteLiteral(" />\r\n    <label");

WriteAttribute("for", Tuple.Create(" for=\'", 605), Tuple.Create("\'", 637)
            
            #line 12 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 611), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textarea")
            
            #line default
            #line hidden
, 611), false)
);

WriteLiteral(">");

            
            #line 12 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                       Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral(" </label>\r\n    <textarea");

WriteAttribute("id", Tuple.Create(" id=\'", 685), Tuple.Create("\'", 716)
            
            #line 13 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 690), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textarea")
            
            #line default
            #line hidden
, 690), false)
);

WriteLiteral(" data-sf-role=\"paragraph-text-field-textarea\"");

WriteAttribute("name", Tuple.Create(" name=\"", 762), Tuple.Create("\"", 795)
            
            #line 13 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                  , Tuple.Create(Tuple.Create("", 769), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 769), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 796), Tuple.Create("\"", 832)
            
            #line 13 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                           , Tuple.Create(Tuple.Create("", 810), Tuple.Create<System.Object, System.Int32>(Model.PlaceholderText
            
            #line default
            #line hidden
, 810), false)
);

WriteLiteral(" ");

            
            #line 13 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                                                                                                                             Write(MvcHtmlString.Create(Model.ValidationAttributes));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 13 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                                                                                                                                                                               Write(Model.Value);

            
            #line default
            #line hidden
WriteLiteral("</textarea>\r\n  \r\n");

            
            #line 15 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
     
            
            #line default
            #line hidden
            
            #line 15 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
      if (!string.IsNullOrEmpty(Model.MetaField.Description))
     {

            
            #line default
            #line hidden
WriteLiteral("         <p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 17 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                          Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 18 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
     }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

            
            #line 21 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/ParagraphTextField/paragraph-text-field.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
