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
    
    #line 3 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
    using Telerik.Sitefinity.Frontend.Taxonomies.Mvc.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/HierarchicalTaxonomy/HierarchicalTaxonomy.MyCategories.cshtml")]
    public partial class _MVC_Views_HierarchicalTaxonomy_HierarchicalTaxonomy_MyCategories_cshtml : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Taxonomies.Mvc.Models.TaxonomyViewModel>
    {

#line 14 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
public System.Web.WebPages.HelperResult RenderTaxaRecursive(TaxonViewModel taxon)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 15 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <li>\r\n");


#line 17 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
         

#line default
#line hidden

#line 17 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
          if (taxon.SubTaxa.Count > 0)
         {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <a data-sf-toggle");

WriteLiteralTo(__razor_helper_writer, " class=\"sf-closed\"");

WriteLiteralTo(__razor_helper_writer, "></a>\r\n");


#line 20 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
         }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n        <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 512), Tuple.Create("\"", 529)

#line 22 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
, Tuple.Create(Tuple.Create("", 519), Tuple.Create<System.Object, System.Int32>(taxon.Url

#line default
#line hidden
, 519), false)
);

WriteLiteralTo(__razor_helper_writer, "><span>");


#line 22 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
     WriteTo(__razor_helper_writer, taxon.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span></a>\r\n\r\n");


#line 24 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
    

#line default
#line hidden

#line 24 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
     if (Model.ShowItemCount)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <span>");


#line 26 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
WriteTo(__razor_helper_writer, Html.Raw(string.Format("({0})", taxon.Count)));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n");


#line 27 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
    }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n    <br />\r\n\r\n");


#line 31 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
    

#line default
#line hidden

#line 31 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
     if (taxon.SubTaxa.Count > 0)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <ul data-sf-submenu");

WriteLiteralTo(__razor_helper_writer, " class=\"sf-submenu sf-closed\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 34 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
                 

#line default
#line hidden

#line 34 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
                  foreach (var childTaxon in taxon.SubTaxa)
                 {
                    

#line default
#line hidden

#line 36 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
WriteTo(__razor_helper_writer, RenderTaxaRecursive(childTaxon));


#line default
#line hidden

#line 36 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
                                                    ;
                 }                


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </ul>\r\n");


#line 39 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
         }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </li>\r\n");


#line 41 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"


#line default
#line hidden
});

#line 41 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
}
#line default
#line hidden

        public _MVC_Views_HierarchicalTaxonomy_HierarchicalTaxonomy_MyCategories_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 143), Tuple.Create("\"", 175)
            
            #line 5 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
, Tuple.Create(Tuple.Create("", 151), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 151), false)
, Tuple.Create(Tuple.Create(" ", 166), Tuple.Create("dropdown", 167), true)
);

WriteLiteral(">\r\n    <ul>\r\n");

            
            #line 7 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
        
            
            #line default
            #line hidden
            
            #line 7 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
         foreach (var taxon in Model.Taxa)
        {
            
            
            #line default
            #line hidden
            
            #line 9 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
       Write(RenderTaxaRecursive(taxon));

            
            #line default
            #line hidden
            
            #line 9 "..\..\MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.MyCategories.cshtml"
                                       ;
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591