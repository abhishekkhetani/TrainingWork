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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.Navigation
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
    
    #line 3 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Navigation/NavigationView.Sitemap.cshtml")]
    public partial class NavigationView_Sitemap : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.INavigationModel>
    {

#line 20 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
public System.Web.WebPages.HelperResult RenderRootLevelNode(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 21 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <li>\r\n        <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 665), Tuple.Create("\"", 681)

#line 23 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
, Tuple.Create(Tuple.Create("", 672), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 672), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 682), Tuple.Create("\"", 707)

#line 23 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
, Tuple.Create(Tuple.Create("", 691), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 691), false)
);

WriteLiteralTo(__razor_helper_writer, "><strong>");


#line 23 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                                WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</strong></a>\r\n");


#line 24 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
        

#line default
#line hidden

#line 24 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
         if (node.ChildNodes.Count > 0)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"nav nav-stacked\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 27 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                

#line default
#line hidden

#line 27 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                 foreach (var childNode in node.ChildNodes)
                {
                    

#line default
#line hidden

#line 29 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode));


#line default
#line hidden

#line 29 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                                                        
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </ul>\r\n");


#line 32 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </li>\r\n");


#line 34 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"


#line default
#line hidden
});

#line 34 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
}
#line default
#line hidden

#line 37 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
public System.Web.WebPages.HelperResult RenderSubLevelsRecursive(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 38 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <li>\r\n        <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1173), Tuple.Create("\"", 1189)

#line 40 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
, Tuple.Create(Tuple.Create("", 1180), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 1180), false)
);

WriteLiteralTo(__razor_helper_writer, " target =\"");


#line 40 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
       WriteTo(__razor_helper_writer, node.LinkTarget);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\">");


#line 40 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                         WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n");


#line 41 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
        

#line default
#line hidden

#line 41 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
         if (node.ChildNodes.Count > 0)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"nav\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 44 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                

#line default
#line hidden

#line 44 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                 foreach (var childNode in node.ChildNodes)
                {
                    

#line default
#line hidden

#line 46 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode));


#line default
#line hidden

#line 46 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                                                        
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </ul>\r\n");


#line 49 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </li>\r\n");


#line 51 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"


#line default
#line hidden
});

#line 51 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
}
#line default
#line hidden

        public NavigationView_Sitemap()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 268), Tuple.Create("\"", 291)
            
            #line 9 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
, Tuple.Create(Tuple.Create("", 276), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 276), false)
);

WriteLiteral(">\r\n    ");

WriteLiteral("\r\n\r\n    <ul");

WriteLiteral(" class=\"nav nav-sitemap\"");

WriteLiteral(">\r\n");

            
            #line 13 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
        
            
            #line default
            #line hidden
            
            #line 13 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
         foreach (var node in Model.Nodes)
        {
            
            
            #line default
            #line hidden
            
            #line 15 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
       Write(RenderRootLevelNode(node));

            
            #line default
            #line hidden
            
            #line 15 "..\..MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                                      ;
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n</div>\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
