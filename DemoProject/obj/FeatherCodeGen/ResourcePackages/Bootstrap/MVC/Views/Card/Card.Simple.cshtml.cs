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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.Card
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Card/Card.Simple.cshtml")]
    public partial class Card_Simple : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Card.Mvc.Models.Card.CardViewModel>
    {
        public Card_Simple()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteAttribute("class", Tuple.Create(" class=\"", 77), Tuple.Create("\"", 100)
            
            #line 3 "..\..MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 85), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 85), false)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 175), Tuple.Create("\"", 203)
            
            #line 6 "..\..MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 181), Tuple.Create<System.Object, System.Int32>(Model.SelectedSizeUrl
            
            #line default
            #line hidden
, 181), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 204), Tuple.Create("\"", 229)
            
            #line 6 "..\..MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 212), Tuple.Create<System.Object, System.Int32>(Model.ImageTitle
            
            #line default
            #line hidden
, 212), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 230), Tuple.Create("\"", 263)
            
            #line 6 "..\..MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 236), Tuple.Create<System.Object, System.Int32>(Model.ImageAlternativeText
            
            #line default
            #line hidden
, 236), false)
);

WriteLiteral(" class=\"img-responsive\"");

WriteLiteral(">\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-md-6 \"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"caption\"");

WriteLiteral(">\r\n                <h3>");

            
            #line 10 "..\..MVC\Views\Card\Card.Simple.cshtml"
               Write(Html.Raw(Model.Heading));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                <p>");

            
            #line 11 "..\..MVC\Views\Card\Card.Simple.cshtml"
              Write(Html.Raw(Model.Description));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n\r\n");

            
            #line 13 "..\..MVC\Views\Card\Card.Simple.cshtml"
                
            
            #line default
            #line hidden
            
            #line 13 "..\..MVC\Views\Card\Card.Simple.cshtml"
                 if (!string.IsNullOrEmpty(Model.ActionName))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <p><a");

WriteAttribute("href", Tuple.Create(" href=\"", 587), Tuple.Create("\"", 610)
            
            #line 15 "..\..MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 594), Tuple.Create<System.Object, System.Int32>(Model.ActionUrl
            
            #line default
            #line hidden
, 594), false)
);

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(" >");

            
            #line 15 "..\..MVC\Views\Card\Card.Simple.cshtml"
                                                                                    Write(Model.ActionName);

            
            #line default
            #line hidden
WriteLiteral("</a></p>\r\n");

            
            #line 16 "..\..MVC\Views\Card\Card.Simple.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
