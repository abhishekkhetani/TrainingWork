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

namespace SitefinityWebApp.ResourcePackages.DemoTemplate.MVC.Views.SearchResults
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
    
    #line 8 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Frontend.Search.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 7 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Libraries.Model;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Modules.Libraries;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/SearchResults/SearchResults.cshtml")]
    public partial class SearchResults : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Search.Mvc.Models.ISearchResultsModel>
    {
        public SearchResults()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 11 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 438), Tuple.Create("\"", 461)
            
            #line 12 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 446), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 446), false)
);

WriteLiteral(">\r\n\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-8\"");

WriteLiteral(">\r\n");

            
            #line 16 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 16 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
             if (@Model.Results.TotalCount > 0)
            {


            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"blog-content\"");

WriteLiteral(">\r\n                            <h1");

WriteLiteral(" style=\"color: #c52d2f; \"");

WriteLiteral(">\"<u>");

            
            #line 20 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                        Write(Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 20 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                  Write(Html.Raw(Model.ResultText));

            
            #line default
            #line hidden
WriteLiteral("</u>\" </h1>\r\n                        </div>\r\n");

            
            #line 22 "..\..MVC\Views\SearchResults\SearchResults.cshtml"

            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <h1>");

            
            #line 26 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
               Write(Html.Resource("No"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 26 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                    Write(Html.Raw(Model.ResultText));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n");

            
            #line 27 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n        <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(">\r\n");

            
            #line 30 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 30 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
             if (Model.AllowSorting && @Model.Results.TotalCount > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <label>\r\n");

WriteLiteral("                    ");

            
            #line 33 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
               Write(Html.Resource("SortBy"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <select");

WriteLiteral(" class=\"userSortDropdown\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1196), Tuple.Create("\"", 1234)
            
            #line 34 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1204), Tuple.Create<System.Object, System.Int32>(Html.Resource("SortDropdown")
            
            #line default
            #line hidden
, 1204), false)
);

WriteLiteral(">\r\n                        <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1269), Tuple.Create("\"", 1302)
            
            #line 35 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1277), Tuple.Create<System.Object, System.Int32>(OrderByOptions.Relevance
            
            #line default
            #line hidden
, 1277), false)
);

WriteLiteral(" ");

            
            #line 35 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                              Write(Model.OrderBy == OrderByOptions.Relevance ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 35 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                                     Write(Html.Resource("Relevance"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                        <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1445), Tuple.Create("\"", 1475)
            
            #line 36 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1453), Tuple.Create<System.Object, System.Int32>(OrderByOptions.Newest
            
            #line default
            #line hidden
, 1453), false)
);

WriteLiteral(" ");

            
            #line 36 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                           Write(Model.OrderBy == OrderByOptions.Newest ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 36 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                               Write(Html.Resource("NewestFirst"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                        <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1617), Tuple.Create("\"", 1647)
            
            #line 37 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1625), Tuple.Create<System.Object, System.Int32>(OrderByOptions.Oldest
            
            #line default
            #line hidden
, 1625), false)
);

WriteLiteral(" ");

            
            #line 37 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                           Write(Model.OrderBy == OrderByOptions.Oldest ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 37 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                               Write(Html.Resource("OldestFirst"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                    </select>\r\n                </label>\r\n");

            
            #line 40 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n\r\n");

            
            #line 44 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 44 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
     if (Model.Languages.Length > 1)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div>\r\n            <span>");

            
            #line 47 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
             Write(Html.Resource("ChangeResultsLanguageLabel"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n");

            
            #line 48 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 48 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
             for (var i = 0; i < Model.Languages.Length; i++)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2088), Tuple.Create("\"", 2171)
            
            #line 50 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2095), Tuple.Create<System.Object, System.Int32>(String.Format(ViewBag.LanguageSearchUrlTemplate, Model.Languages[i].Name)
            
            #line default
            #line hidden
, 2095), false)
);

WriteLiteral(">");

            
            #line 50 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                  Write(Model.Languages[i].DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 51 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                if (i < Model.Languages.Length - 2)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span>, </span>\r\n");

            
            #line 54 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }
                else if (i == Model.Languages.Length - 2)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span> ");

            
            #line 57 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                      Write(Html.Resource("OrLabel"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n");

            
            #line 58 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

            
            #line 61 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"blog-block\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"sf-search-results media-list\"");

WriteLiteral(">\r\n");

            
            #line 64 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 64 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
             foreach (var item in Model.Results.Data)
            {
                var hasLink = item.GetValue("Link") != null && !String.IsNullOrEmpty(item.GetValue("Link").ToString());

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"media sf-media\"");

WriteLiteral(">\r\n\r\n");

            
            #line 69 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 69 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                     if (((Telerik.Sitefinity.Services.Search.Model.Document)item).ItemType.ToString() == typeof(Telerik.Sitefinity.Libraries.Model.Image).ToString())
                    {


            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"media-left sf-img-thmb\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3141), Tuple.Create("\"", 3170)
            
            #line 73 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3148), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 3148), false)
);

WriteLiteral(">\r\n                                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 3210), Tuple.Create("\"", 3238)
            
            #line 74 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3216), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 3216), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 3239), Tuple.Create("\"", 3268)
            
            #line 74 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3245), Tuple.Create<System.Object, System.Int32>(item.GetValue("Title")
            
            #line default
            #line hidden
, 3245), false)
);

WriteLiteral(" width=\"120\"");

WriteLiteral(" />\r\n                            </a>\r\n                        </div>\r\n");

            
            #line 77 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                    }

                    else if (((Telerik.Sitefinity.Services.Search.Model.Document)item).ItemType.ToString() == typeof(Telerik.Sitefinity.Libraries.Model.Video).ToString())
                    {
                        LibrariesManager librariesManager = LibrariesManager.GetManager();
                        var videoTmbId = new Guid((string)item.GetValue("Id"));
                        Video video = librariesManager.GetVideo(videoTmbId);
                        if (video != null)
                        {
                            var thumbUrl = video.ThumbnailUrl;


            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"media-left\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"sf-video-thmb\"");

WriteLiteral(">\r\n\r\n                                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4115), Tuple.Create("\"", 4144)
            
            #line 91 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4122), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 4122), false)
);

WriteLiteral(">\r\n                                        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 4192), Tuple.Create("\"", 4207)
            
            #line 92 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4198), Tuple.Create<System.Object, System.Int32>(thumbUrl
            
            #line default
            #line hidden
, 4198), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 4208), Tuple.Create("\"", 4237)
            
            #line 92 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4214), Tuple.Create<System.Object, System.Int32>(item.GetValue("Title")
            
            #line default
            #line hidden
, 4214), false)
);

WriteLiteral(" width=\"120\"");

WriteLiteral(" />\r\n\r\n                                        <div");

WriteLiteral(" class=\"sf-icon-play\"");

WriteLiteral("></div>\r\n\r\n                                    </a>\r\n                            " +
"    </div>\r\n                            </div>\r\n");

            
            #line 99 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                        }

                    }

                    else
                    {

                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                    <div");

WriteLiteral(" class=\"media-body sf-media-body\"");

WriteLiteral(">\r\n\r\n");

            
            #line 111 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 111 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                         if (hasLink)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"blog-item\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"col-xs-12 col-sm-2 text-center\"");

WriteLiteral(">\r\n                                    </div>\r\n\r\n                                " +
"    <div");

WriteLiteral(" class=\"col-xs-12 col-sm-10 blog-content\"");

WriteLiteral(">\r\n\r\n                                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5071), Tuple.Create("\"", 5100)
            
            #line 120 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 5078), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 5078), false)
);

WriteLiteral("><img");

WriteLiteral(" class=\"img-responsive img-blog\"");

WriteLiteral(" src=\"\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" /></a>\r\n\r\n                                        <h2><a ");

            
            #line 122 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                          Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(" href=\"");

            
            #line 122 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                         Write(item.GetValue("Link"));

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 122 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                                 Write(item.GetValue("Title"));

            
            #line default
            #line hidden
WriteLiteral("</a></h2>\r\n                                        <h3 ");

            
            #line 123 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                       Write(Html.InlineEditingFieldAttributes("Summary", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 123 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                  Write(item.GetValue("Summary"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                                        <a");

WriteLiteral(" class=\"btn btn-primary readmore\"");

WriteAttribute("href", Tuple.Create(" href=\"", 5554), Tuple.Create("\"", 5583)
            
            #line 124 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
  , Tuple.Create(Tuple.Create("", 5561), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 5561), false)
);

WriteLiteral(">Read More <i");

WriteLiteral(" class=\"fa fa-angle-right\"");

WriteLiteral("></i></a>\r\n\r\n                                    </div>\r\n\r\n                      " +
"          </div>\r\n                            </div>");

WriteLiteral("<!--/.blog-item-->\r\n");

            
            #line 130 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                        }
                        else
                        {
                            
            
            #line default
            #line hidden
            
            #line 133 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                       Write(item.GetValue("Title"));

            
            #line default
            #line hidden
            
            #line 133 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                   
                        }

            
            #line default
            #line hidden
WriteLiteral("\r\n                        ");

WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n");

            
            #line 144 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n");

            
            #line 148 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 148 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
     if (Model.DisplayMode == ListDisplayMode.Paging && Model.TotalPagesCount != null && Model.TotalPagesCount > 1)
    {
        if (Model.CurrentPage == Model.TotalPagesCount)
        {

            
            #line default
            #line hidden
WriteLiteral("            <em");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 152 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                               Write((Model.ItemsPerPage * Model.TotalPagesCount) - Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" of ");

            
            #line 152 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                            Write(Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" results</em>\r\n");

            
            #line 153 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <em");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 156 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                              Write(Model.ItemsPerPage);

            
            #line default
            #line hidden
WriteLiteral(" of ");

            
            #line 156 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                     Write(Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" results</em>\r\n");

            
            #line 157 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
        }


            
            #line default
            #line hidden
WriteLiteral("        <div>\r\n");

WriteLiteral("            ");

            
            #line 160 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
       Write(Html.Action("Index", "ContentPager", new
                       {
                           currentPage = Model.CurrentPage,
                           totalPagesCount = Model.TotalPagesCount,
                           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
                       }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");

            
            #line 167 "..\..MVC\Views\SearchResults\SearchResults.cshtml"

    }

            
            #line default
            #line hidden
WriteLiteral("    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResOrderBy\"");

WriteAttribute("value", Tuple.Create(" value=\"", 7229), Tuple.Create("\"", 7268)
            
            #line 169 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7237), Tuple.Create<System.Object, System.Int32>(Request.QueryString["orderBy"]
            
            #line default
            #line hidden
, 7237), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResLanguage\"");

WriteAttribute("value", Tuple.Create(" value=\"", 7331), Tuple.Create("\"", 7371)
            
            #line 170 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7339), Tuple.Create<System.Object, System.Int32>(Request.QueryString["language"]
            
            #line default
            #line hidden
, 7339), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResIndexCatalogue\"");

WriteAttribute("value", Tuple.Create(" value=\"", 7440), Tuple.Create("\"", 7486)
            
            #line 171 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7448), Tuple.Create<System.Object, System.Int32>(Request.QueryString["indexCatalogue"]
            
            #line default
            #line hidden
, 7448), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResQuery\"");

WriteAttribute("value", Tuple.Create(" value=\'", 7546), Tuple.Create("\'", 7589)
            
            #line 172 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7554), Tuple.Create<System.Object, System.Int32>(Request.QueryString["searchQuery"]
            
            #line default
            #line hidden
, 7554), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResWordsMode\"");

WriteAttribute("value", Tuple.Create(" value=\'", 7653), Tuple.Create("\'", 7694)
            
            #line 173 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7661), Tuple.Create<System.Object, System.Int32>(Request.QueryString["wordsMode"]
            
            #line default
            #line hidden
, 7661), false)
);

WriteLiteral(" />\r\n\r\n</div>\r\n\r\n\r\n");

            
            #line 178 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/SearchResults/Search-results.js"), "bottom"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
