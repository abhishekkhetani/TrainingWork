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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.AccountActivation
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
    
    #line 3 "..\..MVC\Views\AccountActivation\AccountActivation.AccountActivation.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/AccountActivation/AccountActivation.AccountActivation.cshtml")]
    public partial class AccountActivation_AccountActivation : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.AccountActivation.AccountActivationViewModel>
    {
        public AccountActivation_AccountActivation()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 157), Tuple.Create("\"", 180)
            
            #line 5 "..\..MVC\Views\AccountActivation\AccountActivation.AccountActivation.cshtml"
, Tuple.Create(Tuple.Create("", 165), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 165), false)
);

WriteLiteral(">\r\n");

            
            #line 6 "..\..MVC\Views\AccountActivation\AccountActivation.AccountActivation.cshtml"
    
            
            #line default
            #line hidden
            
            #line 6 "..\..MVC\Views\AccountActivation\AccountActivation.AccountActivation.cshtml"
     if (Model.Activated)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3>");

            
            #line 8 "..\..MVC\Views\AccountActivation\AccountActivation.AccountActivation.cshtml"
       Write(Html.Resource("AccountActivationSuccess"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 9 "..\..MVC\Views\AccountActivation\AccountActivation.AccountActivation.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 291), Tuple.Create("\"", 319)
            
            #line 10 "..\..MVC\Views\AccountActivation\AccountActivation.AccountActivation.cshtml"
, Tuple.Create(Tuple.Create("", 298), Tuple.Create<System.Object, System.Int32>(Model.ProfilePageUrl
            
            #line default
            #line hidden
, 298), false)
);

WriteLiteral(">");

            
            #line 10 "..\..MVC\Views\AccountActivation\AccountActivation.AccountActivation.cshtml"
                                   Write(Html.Resource("ProfilePageUrlTitle"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 11 "..\..MVC\Views\AccountActivation\AccountActivation.AccountActivation.cshtml"
    }
    else if (Model.AttemptedActivation)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3>");

            
            #line 14 "..\..MVC\Views\AccountActivation\AccountActivation.AccountActivation.cshtml"
       Write(Html.Resource("AccountActivationFail"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 15 "..\..MVC\Views\AccountActivation\AccountActivation.AccountActivation.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
