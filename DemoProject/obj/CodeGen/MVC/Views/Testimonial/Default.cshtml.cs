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
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Testimonial/Default.cshtml")]
    public partial class _MVC_Views_Testimonial_Default_cshtml : System.Web.Mvc.WebViewPage<List<SitefinityWebApp.Mvc.Models.TestimonialModel>>
    {
        public _MVC_Views_Testimonial_Default_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n\r\n\r\n");

            
            #line 8 "..\..\MVC\Views\Testimonial\Default.cshtml"
 foreach(SitefinityWebApp.Mvc.Models.TestimonialModel testimonial in Model){
    

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"col-md-4 wow fadeInDown\"");

WriteLiteral(">\n                    <div");

WriteLiteral(" class=\"clients-comments text-center\"");

WriteLiteral(">\n                        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 329), Tuple.Create("\"", 358)
            
            #line 12 "..\..\MVC\Views\Testimonial\Default.cshtml"
, Tuple.Create(Tuple.Create("", 335), Tuple.Create<System.Object, System.Int32>(testimonial.Image_Path
            
            #line default
            #line hidden
, 335), false)
);

WriteLiteral(" class=\"img-circle\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(">\n                        <h3>");

            
            #line 13 "..\..\MVC\Views\Testimonial\Default.cshtml"
                       Write(testimonial.Description);

            
            #line default
            #line hidden
WriteLiteral("</h3>\n                        <h4><span>-");

            
            #line 14 "..\..\MVC\Views\Testimonial\Default.cshtml"
                              Write(testimonial.Client_Name);

            
            #line default
            #line hidden
WriteLiteral(" /</span>  ");

            
            #line 14 "..\..\MVC\Views\Testimonial\Default.cshtml"
                                                                 Write(testimonial.Designation);

            
            #line default
            #line hidden
WriteLiteral("</h4>\n                    </div>\n                </div>\r\n");

            
            #line 17 "..\..\MVC\Views\Testimonial\Default.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
