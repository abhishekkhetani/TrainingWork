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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.Lists
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
    
    #line 5 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
    using Telerik.Sitefinity.Frontend.Lists.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Lists/List.ExpandableList.cshtml")]
    public partial class List_ExpandableList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_ExpandableList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
Write(Html.Script(ScriptRef.JQuery));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 255), Tuple.Create("\"", 278)
            
            #line 9 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
, Tuple.Create(Tuple.Create("", 263), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 263), false)
);

WriteLiteral(" data-sf-role=\"lists\"");

WriteLiteral(">\r\n\r\n    <div");

WriteLiteral(" class=\"sf-list sf-list--expandable clearfix\"");

WriteLiteral(">\r\n    \r\n        <div");

WriteLiteral(" class=\"pull-right\"");

WriteLiteral(">\r\n            <a");

WriteLiteral("  href=\"#\"");

WriteLiteral(" data-sf-role=\"expandAll\"");

WriteLiteral(">");

            
            #line 14 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
                                             Write(Html.Resource("ExpandAll"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            <a");

WriteLiteral(" class=\"pull-right\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"collapseAll\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">");

            
            #line 15 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
                                                                                       Write(Html.Resource("CollapseAll"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"sf-list-item pull-left\"");

WriteLiteral(">\r\n");

            
            #line 19 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 19 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
             foreach (var item in Model.Items)
            {


            
            #line default
            #line hidden
WriteLiteral("                <h3 ");

            
            #line 22 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
               Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 22 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
                                                                                                                   Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 23 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
               Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h3>\r\n");

            
            #line 25 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"

        
                foreach (var listItem in ((ListViewModel)item).ListItemViewModel.Items)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div ");

            
            #line 29 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
                    Write(Html.InlineEditingAttributes(Model.ProviderName, ((ListViewModel)item).ListItemViewModel.ContentType.FullName, (Guid)listItem.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" ");

            
            #line 30 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
                                                Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(" data-sf-role=\"toggleLink\"><i");

WriteLiteral(" class=\"text-muted sf-icon glyphicon glyphicon-chevron-right\"");

WriteLiteral("></i>");

            
            #line 30 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
                                                                                                                                                                                                       Write(listItem.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                        <div ");

            
            #line 31 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
                        Write(Html.InlineEditingFieldAttributes("Content", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(" style=\"display:none;\" class=\"sf-list-content\">\r\n");

WriteLiteral("                            ");

            
            #line 32 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
                       Write(Html.Raw(@listItem.Fields.Content));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");

            
            #line 35 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");

            
            #line 41 "..\..MVC\Views\Lists\List.ExpandableList.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Lists/lists.js")));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
    $('[data-sf-role=toggleLink]').on('click', function () {
        var link = $(this);
        var icon = link.find('.sf-icon');
        if (link.hasClass(""expanded"")) {
            icon.removeClass('glyphicon-chevron-down');
            icon.addClass('glyphicon-chevron-right');
        }
        else {
            icon.removeClass('glyphicon-chevron-right');
            icon.addClass('glyphicon-chevron-down');
        }
    });

    $('[data-sf-role=expandAll]').on('click', function () {
        var wrapper = $(this).closest('[data-sf-role=lists]');
        var links = wrapper.find('[data-sf-role=toggleLink]');
        var icons = links.find("".sf-icon"");
        icons.removeClass('glyphicon-chevron-right');
        icons.addClass('glyphicon-chevron-down');
    });

    $('[data-sf-role=collapseAll]').on('click', function () {
        var wrapper = $(this).closest('[data-sf-role=lists]');
        var links = wrapper.find('[data-sf-role=toggleLink]');
        var icons = links.find("".sf-icon"");
        icons.removeClass('glyphicon-chevron-down');
        icons.addClass('glyphicon-chevron-right');
    });
</script>
");

        }
    }
}
#pragma warning restore 1591
