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

namespace SitefinityWebApp.ResourcePackages.DemoTemplate.MVC.Views.HierarchicalTaxonomy
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/HierarchicalTaxonomy/HierarchicalTaxonomy.CategoriesList.cshtml")]
    public partial class HierarchicalTaxonomy_CategoriesList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Taxonomies.Mvc.Models.TaxonomyViewModel>
    {
        public HierarchicalTaxonomy_CategoriesList()
        {
        }
        public override void Execute()
        {
WriteLiteral("<ul");

WriteAttribute("class", Tuple.Create(" class=\"", 81), Tuple.Create("\"", 132)
, Tuple.Create(Tuple.Create("", 89), Tuple.Create("blog_category", 89), true)
            
            #line 3 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
, Tuple.Create(Tuple.Create(" ", 102), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 103), false)
, Tuple.Create(Tuple.Create(" ", 118), Tuple.Create("list-unstyled", 119), true)
);

WriteLiteral(">\r\n");

            
            #line 4 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 4 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
     foreach (var taxon in Model.Taxa)
    {

            
            #line default
            #line hidden
WriteLiteral("        <li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 211), Tuple.Create("\"", 228)
            
            #line 7 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
, Tuple.Create(Tuple.Create("", 218), Tuple.Create<System.Object, System.Int32>(taxon.Url
            
            #line default
            #line hidden
, 218), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 8 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
           Write(taxon.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 10 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 10 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
             if (Model.ShowItemCount)
            {


            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"badge\"");

WriteLiteral(">");

            
            #line 13 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
                               Write(Html.Raw(string.Format("{0}", taxon.Count)));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 14 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"

            }

            
            #line default
            #line hidden
WriteLiteral("        </a>\r\n    </li>\r\n");

            
            #line 18 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"

    }

            
            #line default
            #line hidden
WriteLiteral("</ul>");

        }
    }
}
#pragma warning restore 1591