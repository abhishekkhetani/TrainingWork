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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.ChangePassword
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
    
    #line 4 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/ChangePassword/ChangePassword.ChangePassword.cshtml")]
    public partial class ChangePassword_ChangePassword : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.ChangePassword.ChangePasswordViewModel>
    {
        public ChangePassword_ChangePassword()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 186), Tuple.Create("\"", 209)
            
            #line 6 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
, Tuple.Create(Tuple.Create("", 194), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 194), false)
);

WriteLiteral(">\r\n");

            
            #line 7 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
    
            
            #line default
            #line hidden
            
            #line 7 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
     if (Model.PasswordChanged)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3>");

            
            #line 9 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
       Write(Html.Resource("ChangePasswordSuccess"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 10 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3>");

            
            #line 13 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
       Write(Html.Resource("ChangePasswordHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 14 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
        
        using (Html.BeginFormSitefinity("SetChangePassword", "ChangePassword"))
        {
            if (!string.IsNullOrEmpty(Model.Error))
            {


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 21 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
               Write(Model.Error);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 23 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"

            }
    

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label>\r\n");

WriteLiteral("                    ");

            
            #line 28 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
               Write(Html.Resource("ChangePasswordOldPassword"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n");

WriteLiteral("               ");

            
            #line 30 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
          Write(Html.PasswordFor(u => u.OldPassword, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label>\r\n");

WriteLiteral("                    ");

            
            #line 35 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
               Write(Html.Resource("ChangePasswordNewPassword"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n\r\n");

WriteLiteral("                ");

            
            #line 38 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
           Write(Html.PasswordFor(u => u.NewPassword, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label>\r\n");

WriteLiteral("                    ");

            
            #line 43 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
               Write(Html.Resource("ChangePasswordRepeatPassword"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n\r\n");

WriteLiteral("                ");

            
            #line 46 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
           Write(Html.PasswordFor(u => u.RepeatPassword, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n            </div>    \r\n");

            
            #line 49 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
            

            
            #line default
            #line hidden
WriteLiteral("           <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(">");

            
            #line 50 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
                                                    Write(Html.Resource("ChangePasswordSaveButton"));

            
            #line default
            #line hidden
WriteLiteral("</button> \r\n");

            
            #line 51 "..\..MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
