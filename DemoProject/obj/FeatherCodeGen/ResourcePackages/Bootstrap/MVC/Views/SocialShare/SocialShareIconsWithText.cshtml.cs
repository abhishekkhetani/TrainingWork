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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.SocialShare
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
    
    #line 3 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 2 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
    using Telerik.Sitefinity.Frontend.SocialShare.SocialShareHelpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/SocialShare/SocialShareIconsWithText.cshtml")]
    public partial class SocialShareIconsWithText : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.SocialShare.Mvc.Models.SocialShareModel>
    {
        public SocialShareIconsWithText()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 5 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
  
    var shareUrl = SocialShareButtons.ShareUrl;
    var unencodedPageTitle = Model.ItemTitle != null ? Model.ItemTitle : SocialShareButtons.PageTitle;
    var pageTitle = HttpUtility.UrlEncode(unencodedPageTitle);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 11 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
Write(Html.StyleSheet(Url.WidgetContent("assets/dist/css/sf-social-share.min.css"), "head", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<style>\r\n    .color {color: blue;}\r\n</style>\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 568), Tuple.Create("\"", 591)
            
            #line 17 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
, Tuple.Create(Tuple.Create("", 576), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 576), false)
);

WriteLiteral(">\r\n    <ul");

WriteLiteral(" class=\"list-inline sf-social-share\"");

WriteLiteral(">\r\n");

            
            #line 19 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
        
            
            #line default
            #line hidden
            
            #line 19 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
         foreach (var button in Model.SocialButtons)
        {
            switch (button.ButtonName)
            {
                case "Facebook":

            
            #line default
            #line hidden
WriteLiteral("                    <li>\r\n                        <div");

WriteLiteral(" class=\'fb-share-button\'");

WriteLiteral(" data-href=\'");

            
            #line 25 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                           Write(shareUrl);

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-type=\'button_count\'");

WriteLiteral("></div>\r\n                        <div");

WriteLiteral(" id=\'fb-root\'");

WriteLiteral(@"></div>
                        <script>
                            (function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0]; if (d.getElementById(id)) return; js = d.createElement(s); js.id = id; js.src = '//connect.facebook.net/en_EN/all.js#xfbml=1'; fjs.parentNode.insertBefore(js, fjs); }(document, 'script', 'facebook-jssdk'));
                        </script>
                    </li>
");

            
            #line 31 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "Twitter":

            
            #line default
            #line hidden
WriteLiteral("                <li>\r\n                    <a");

WriteLiteral(" href=\'https://twitter.com/share\'");

WriteLiteral(" title=\'Share on Twitter\'");

WriteLiteral(" class=\'twitter-share-button\'");

WriteLiteral(" data-url=");

            
            #line 34 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                                                                  Write(shareUrl);

            
            #line default
            #line hidden
WriteLiteral(" data-count=\'horizontal\'");

WriteLiteral(@">
                        Tweet
                    </a>
                    <script>
                        !function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0], p = /^http:/.test(d.location) ? 'http' : 'https'; if (!d.getElementById(id)) { js = d.createElement(s); js.id = id; js.src = p + '://platform.twitter.com/widgets.js'; fjs.parentNode.insertBefore(js, fjs); } }(document, 'script', 'twitter-wjs');
                    </script>
                </li>
");

            
            #line 41 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "LinkedIn":

            
            #line default
            #line hidden
WriteLiteral("                <li>\r\n                    <script");

WriteLiteral(" src=\"//platform.linkedin.com/in.js\"");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n                        lang: en_US\r\n                    </script>\r\n          " +
"          <script");

WriteLiteral(" type=\"IN/Share\"");

WriteLiteral(" data-url=\'");

            
            #line 47 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                 Write(shareUrl);

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-counter=\"right\"");

WriteLiteral(">\r\n                    </script>\r\n                </li>\r\n");

            
            #line 50 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "GooglePlusOne":

            
            #line default
            #line hidden
WriteLiteral("                <li>\r\n                    <div");

WriteLiteral(" class=\'g-plusone\'");

WriteLiteral(" data-size=\'medium\'");

WriteLiteral("></div>\r\n                    <script");

WriteLiteral(" type=\'text/javascript\'");

WriteLiteral(@">
                        (function () { var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true; po.src = 'https://apis.google.com/js/platform.js'; var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s); })();
                    </script>
                </li>
");

            
            #line 58 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "Blogger":

            
            #line default
            #line hidden
WriteLiteral("                <li>\r\n                    <a");

WriteLiteral(" class=\"sf-share-button\"");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 3153), Tuple.Create("\"", 3302)
, Tuple.Create(Tuple.Create("", 3163), Tuple.Create("window.open(\'https://www.blogger.com/blog_this.pyra?t&u=", 3163), true)
            
            #line 61 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                         , Tuple.Create(Tuple.Create("", 3219), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 3219), false)
, Tuple.Create(Tuple.Create("", 3228), Tuple.Create("&n=", 3228), true)
            
            #line 61 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                     , Tuple.Create(Tuple.Create("", 3231), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 3231), false)
, Tuple.Create(Tuple.Create("", 3241), Tuple.Create("\',", 3241), true)
, Tuple.Create(Tuple.Create(" ", 3243), Tuple.Create("\'Blogger\',\'toolbar=no,width=550,height=550\');", 3244), true)
, Tuple.Create(Tuple.Create(" ", 3289), Tuple.Create("return", 3290), true)
, Tuple.Create(Tuple.Create(" ", 3296), Tuple.Create("false", 3297), true)
);

WriteLiteral(" title=\"Share on Blogger\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"sf-icon-blogger\"");

WriteLiteral("></span>\r\n                        <strong>Blogger</strong>\r\n                    <" +
"/a>\r\n                </li>\r\n");

            
            #line 66 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "Delicious":

            
            #line default
            #line hidden
WriteLiteral("                <li>\r\n                    <a");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 3609), Tuple.Create("\"", 3789)
, Tuple.Create(Tuple.Create("", 3619), Tuple.Create("window.open(\'https://delicious.com/save?v=5&provider=Telerik&noui&jump=close&url=" +
"", 3619), true)
            
            #line 69 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                          , Tuple.Create(Tuple.Create("", 3700), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 3700), false)
, Tuple.Create(Tuple.Create("", 3709), Tuple.Create("&title=", 3709), true)
            
            #line 69 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                          , Tuple.Create(Tuple.Create("", 3716), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 3716), false)
, Tuple.Create(Tuple.Create("", 3726), Tuple.Create(",", 3726), true)
, Tuple.Create(Tuple.Create(" ", 3727), Tuple.Create("\'delicious\',\'toolbar=no,width=550,height=550\');", 3728), true)
, Tuple.Create(Tuple.Create(" ", 3775), Tuple.Create("return", 3776), true)
, Tuple.Create(Tuple.Create(" ", 3782), Tuple.Create("false;", 3783), true)
);

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"https://delicious.com/img/logo.png\"");

WriteLiteral(" height=\"16\"");

WriteLiteral(" width=\"16\"");

WriteLiteral(" alt=\"Delicious\"");

WriteLiteral("> Save this on Delicious\r\n                    </a>\r\n                </li>\r\n");

            
            #line 73 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "Tumblr":

            
            #line default
            #line hidden
WriteLiteral("                <li>\r\n                    <a");

WriteLiteral(" href=\"http://www.tumblr.com/share\"");

WriteLiteral(" title=\"Share on Tumblr\"");

WriteLiteral(" style=\"display:inline-block; text-indent:-9999px; overflow:hidden; width:81px; h" +
"eight:20px; background:url(\'https://platform.tumblr.com/v1/share_1.png\') top lef" +
"t no-repeat transparent;\"");

WriteLiteral(">Share on Tumblr</a>\r\n                </li>\r\n");

            
            #line 78 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "GoogleBookmarks":

            
            #line default
            #line hidden
WriteLiteral("                <li>\r\n                    <a");

WriteLiteral(" class=\"sf-share-button\"");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 4516), Tuple.Create("\"", 4685)
, Tuple.Create(Tuple.Create("", 4526), Tuple.Create("window.open(\'https://www.google.com/bookmarks/mark?op=add&bkmk=", 4526), true)
            
            #line 81 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                , Tuple.Create(Tuple.Create("", 4589), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 4589), false)
, Tuple.Create(Tuple.Create("", 4598), Tuple.Create("&title=", 4598), true)
            
            #line 81 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                , Tuple.Create(Tuple.Create("", 4605), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 4605), false)
, Tuple.Create(Tuple.Create("", 4615), Tuple.Create("\',", 4615), true)
, Tuple.Create(Tuple.Create(" ", 4617), Tuple.Create("\'Google", 4618), true)
, Tuple.Create(Tuple.Create(" ", 4625), Tuple.Create("bookmarks\',\'toolbar=no,width=550,height=550\');", 4626), true)
, Tuple.Create(Tuple.Create(" ", 4672), Tuple.Create("return", 4673), true)
, Tuple.Create(Tuple.Create(" ", 4679), Tuple.Create("false", 4680), true)
);

WriteLiteral(" title=\"Share on GoogleBookmarks\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"sf-icon-google\"");

WriteLiteral("></span>\r\n                        <strong>Google Bookmarks</strong>\r\n            " +
"        </a>\r\n                </li>\r\n");

            
            #line 86 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "Digg":

            
            #line default
            #line hidden
WriteLiteral("                <li>\r\n                    <a");

WriteLiteral(" class=\"sf-share-button\"");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 5027), Tuple.Create("\"", 5161)
, Tuple.Create(Tuple.Create("", 5037), Tuple.Create("window.open(\'http://digg.com/submit?url=", 5037), true)
            
            #line 89 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                         , Tuple.Create(Tuple.Create("", 5077), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 5077), false)
, Tuple.Create(Tuple.Create("", 5086), Tuple.Create("&title=", 5086), true)
            
            #line 89 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                         , Tuple.Create(Tuple.Create("", 5093), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 5093), false)
, Tuple.Create(Tuple.Create("", 5103), Tuple.Create("\',", 5103), true)
, Tuple.Create(Tuple.Create(" ", 5105), Tuple.Create("\'Digg\',\'toolbar=no,width=550,height=550\');", 5106), true)
, Tuple.Create(Tuple.Create(" ", 5148), Tuple.Create("return", 5149), true)
, Tuple.Create(Tuple.Create(" ", 5155), Tuple.Create("false", 5156), true)
);

WriteLiteral(" title=\"Share on Digg\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"sf-icon-digg\"");

WriteLiteral("></span> <strong>Digg</strong>\r\n                    </a>\r\n                </li>\r\n" +
"");

            
            #line 93 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "MySpace":

            
            #line default
            #line hidden
WriteLiteral("                <li>\r\n                    <a");

WriteLiteral(" class=\"sf-share-button\"");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 5456), Tuple.Create("\"", 5606)
, Tuple.Create(Tuple.Create("", 5466), Tuple.Create("window.open(\'http://myspace.com/Modules/PostTo/Pages/?u=", 5466), true)
            
            #line 96 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                         , Tuple.Create(Tuple.Create("", 5522), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 5522), false)
, Tuple.Create(Tuple.Create("", 5531), Tuple.Create("&t=", 5531), true)
            
            #line 96 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                     , Tuple.Create(Tuple.Create("", 5534), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 5534), false)
, Tuple.Create(Tuple.Create("", 5544), Tuple.Create("\',", 5544), true)
, Tuple.Create(Tuple.Create(" ", 5546), Tuple.Create("\'My", 5547), true)
, Tuple.Create(Tuple.Create(" ", 5550), Tuple.Create("Space\',\'toolbar=no,width=550,height=550\');", 5551), true)
, Tuple.Create(Tuple.Create(" ", 5593), Tuple.Create("return", 5594), true)
, Tuple.Create(Tuple.Create(" ", 5600), Tuple.Create("false", 5601), true)
);

WriteLiteral(" title=\"Share on MySpace\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"sf-icon-myspace\"");

WriteLiteral("></span>\r\n                        <strong>MySpace</strong>\r\n                    <" +
"/a>\r\n                </li>\r\n");

            
            #line 101 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "StumbleUpon":

            
            #line default
            #line hidden
WriteLiteral("                <li>\r\n                    <!-- Place this tag where you want the " +
"su badge to render -->\r\n                    <su:badge");

WriteLiteral(" layout=\"2\"");

WriteLiteral("></su:badge>\r\n\r\n                    <!-- Place this snippet wherever appropriate " +
"-->\r\n                    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
                        (function () {
                            var li = document.createElement('script'); li.type = 'text/javascript'; li.async = true;
                            li.src = ('https:' == document.location.protocol ? 'https:' : 'http:') + '//platform.stumbleupon.com/1/widgets.js';
                            var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(li, s);
                        })();
                    </script>

                </li>
");

            
            #line 117 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "Reddit":

            
            #line default
            #line hidden
WriteLiteral("                <li>\r\n                    <a");

WriteLiteral(" href=\"//www.reddit.com/submit\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 6786), Tuple.Create("\"", 6867)
, Tuple.Create(Tuple.Create("", 6796), Tuple.Create("window.location", 6796), true)
, Tuple.Create(Tuple.Create(" ", 6811), Tuple.Create("=", 6812), true)
, Tuple.Create(Tuple.Create(" ", 6813), Tuple.Create("\'//www.reddit.com/submit?url=", 6814), true)
            
            #line 120 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                              , Tuple.Create(Tuple.Create("", 6843), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 6843), false)
, Tuple.Create(Tuple.Create("", 6852), Tuple.Create("\';", 6852), true)
, Tuple.Create(Tuple.Create(" ", 6854), Tuple.Create("return", 6855), true)
, Tuple.Create(Tuple.Create(" ", 6861), Tuple.Create("false", 6862), true)
);

WriteLiteral("> <img");

WriteLiteral(" src=\"//www.redditstatic.com/spreddit7.gif\"");

WriteLiteral(" alt=\"submit to reddit\"");

WriteLiteral(" border=\"0\"");

WriteLiteral(" /> </a>\r\n                </li>\r\n");

            
            #line 122 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;

                case "MailTo":

            
            #line default
            #line hidden
WriteLiteral("                <li>\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 7090), Tuple.Create("\"", 7138)
, Tuple.Create(Tuple.Create("", 7097), Tuple.Create("mailto:?body=", 7097), true)
            
            #line 126 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
, Tuple.Create(Tuple.Create("", 7110), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 7110), false)
, Tuple.Create(Tuple.Create("", 7119), Tuple.Create("&subject=", 7119), true)
            
            #line 126 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
, Tuple.Create(Tuple.Create("", 7128), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 7128), false)
);

WriteLiteral(" class=\"sf-share-button\"");

WriteLiteral(" title=\"Tell a friend\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"sf-icon-mailto\"");

WriteLiteral("></span>\r\n                        <strong>Email</strong>\r\n                    </a" +
">\r\n                </li>\r\n");

            
            #line 131 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                default:
                    break;
            }
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
