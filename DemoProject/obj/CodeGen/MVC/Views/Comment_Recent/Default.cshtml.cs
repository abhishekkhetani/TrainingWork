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

namespace ASP
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Comment_Recent/Default.cshtml")]
    public partial class _MVC_Views_Comment_Recent_Default_cshtml : System.Web.Mvc.WebViewPage<SitefinityWebApp.Mvc.Models.Comment_RecentModel>
    {
        public _MVC_Views_Comment_Recent_Default_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 4 "..\..\MVC\Views\Comment_Recent\Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 4 "..\..\MVC\Views\Comment_Recent\Default.cshtml"
     foreach (var comment in ViewBag.Comments)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"single_comments\"");

WriteLiteral(">\r\n            <img");

WriteLiteral(" src=\"/images/default-source/Project/blog/avatar3.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n            <p>");

            
            #line 8 "..\..\MVC\Views\Comment_Recent\Default.cshtml"
          Write(comment.Message);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            <div");

WriteLiteral(" class=\"entry-meta small muted\"");

WriteLiteral(">\r\n                <span>By <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">");

            
            #line 10 "..\..\MVC\Views\Comment_Recent\Default.cshtml"
                                Write(comment.Author.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></span><span>On <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Creative</a></span>\r\n            </div>\r\n        </div>\r\n");

WriteLiteral("      <br />\r\n");

            
            #line 14 "..\..\MVC\Views\Comment_Recent\Default.cshtml"
    }
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
