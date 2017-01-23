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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.SearchBox
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
    
    #line 5 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/SearchBox/SearchBox.cshtml")]
    public partial class SearchBox : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Search.Mvc.Models.ISearchBoxModel>
    {
        public SearchBox()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
  
    var searchTextBoxId = Guid.NewGuid();
    var searchButtonId = Guid.NewGuid();
 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 12 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(!String.IsNullOrEmpty(Model.CssClass) ?
    Html.Raw(String.Format("<div class=\"{0} form-inline\">", Model.CssClass)) :
    Html.Raw("<div class=\"form-inline\">"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <input");

WriteLiteral(" type=\"search\"");

WriteAttribute("title", Tuple.Create(" title=\"", 526), Tuple.Create("\"", 563)
            
            #line 16 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 534), Tuple.Create<System.Object, System.Int32>(Html.Resource("SearchInput")
            
            #line default
            #line hidden
, 534), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 564), Tuple.Create("\"", 599)
            
            #line 16 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
 , Tuple.Create(Tuple.Create("", 578), Tuple.Create<System.Object, System.Int32>(Model.BackgroundHint
            
            #line default
            #line hidden
, 578), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 600), Tuple.Create("\"", 631)
            
            #line 16 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                            , Tuple.Create(Tuple.Create("", 605), Tuple.Create<System.Object, System.Int32>(Html.Raw(searchTextBoxId)
            
            #line default
            #line hidden
, 605), false)
);

WriteLiteral(" class=\"form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 653), Tuple.Create("\"", 691)
            
            #line 16 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                                                                                    , Tuple.Create(Tuple.Create("", 661), Tuple.Create<System.Object, System.Int32>(Html.Raw(ViewBag.SearchQuery)
            
            #line default
            #line hidden
, 661), false)
);

WriteLiteral("/>\r\n    </div>\r\n    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteAttribute("id", Tuple.Create(" id=\"", 757), Tuple.Create("\"", 787)
            
            #line 18 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 762), Tuple.Create<System.Object, System.Int32>(Html.Raw(searchButtonId)
            
            #line default
            #line hidden
, 762), false)
);

WriteLiteral(">");

            
            #line 18 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                                                                            Write(Html.Resource("SearchLabel"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n\t\r\n\t<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"resultsUrl\"");

WriteAttribute("value", Tuple.Create(" value=\"", 879), Tuple.Create("\"", 914)
            
            #line 20 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 887), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.ResultsUrl)
            
            #line default
            #line hidden
, 887), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"indexCatalogue\"");

WriteAttribute("value", Tuple.Create(" value=\"", 974), Tuple.Create("\"", 1013)
            
            #line 21 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 982), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.IndexCatalogue)
            
            #line default
            #line hidden
, 982), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"wordsMode\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1068), Tuple.Create("\"", 1113)
            
            #line 22 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1076), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.WordsMode.ToString())
            
            #line default
            #line hidden
, 1076), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"disableSuggestions\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1177), Tuple.Create("\'", 1251)
            
            #line 23 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1185), Tuple.Create<System.Object, System.Int32>(Model.DisableSuggestions ? Html.Raw("true") : Html.Raw("false")
            
            #line default
            #line hidden
, 1185), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"minSuggestionLength\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1316), Tuple.Create("\"", 1360)
            
            #line 24 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1324), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.MinSuggestionLength)
            
            #line default
            #line hidden
, 1324), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"suggestionFields\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1422), Tuple.Create("\"", 1463)
            
            #line 25 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1430), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.SuggestionFields)
            
            #line default
            #line hidden
, 1430), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"language\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1517), Tuple.Create("\"", 1550)
            
            #line 26 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1525), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.Language)
            
            #line default
            #line hidden
, 1525), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"suggestionsRoute\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1612), Tuple.Create("\"", 1653)
            
            #line 27 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1620), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.SuggestionsRoute)
            
            #line default
            #line hidden
, 1620), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchTextBoxId\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1714), Tuple.Create("\'", 1757)
            
            #line 28 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1722), Tuple.Create<System.Object, System.Int32>("#" + searchTextBoxId.ToString()
            
            #line default
            #line hidden
, 1722), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchButtonId\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1817), Tuple.Create("\'", 1859)
            
            #line 29 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1825), Tuple.Create<System.Object, System.Int32>("#" + searchButtonId.ToString()
            
            #line default
            #line hidden
, 1825), false)
);

WriteLiteral(" />\r\n</div>\r\n\r\n");

WriteLiteral("\r\n\r\n");

            
            #line 34 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 35 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(ScriptRef.JQueryUI, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 37 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/SearchBox/Search-box.js"), "bottom"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591