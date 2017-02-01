using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using Telerik.Sitefinity.Modules.Blogs;
using System.Collections.Generic;
using Telerik.Sitefinity.DynamicModules;
using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.Libraries.Model;
using Telerik.Sitefinity.RelatedData;
using Telerik.Sitefinity.Modules.Libraries;
using Telerik.Sitefinity.Taxonomies;
using Telerik.Sitefinity.Taxonomies.Model;
using Telerik.Sitefinity.Services;
using Telerik.Sitefinity.Services.Comments;
using Telerik.Sitefinity;
using System.Threading;
using Telerik.Sitefinity.Web.UI;
using Telerik.Sitefinity.Blogs.Model;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Comment_Recent", Title = "Comment_Recent", SectionName = "MvcWidgets"), Telerik.Sitefinity.Web.UI.ControlDesign.ControlDesigner(typeof(SitefinityWebApp.WidgetDesigners.Comment_Recent.Comment_RecentDesigner))]
    public class Comment_RecentController : Controller
    {
        /// <summary>
        /// Gets or sets the Image.
        /// </summary>
        [Category("String Properties")]
        public string Image { get; set; }
        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        [Category("String Properties")]
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the Author.
        [Category("String Properties")]
        public string Author { get; set; }
        /// <summary>
        /// Gets or sets the Category.
        [Category("String Properties")]
        public string Category { get; set; }

        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            // Gets an instance of the comments service
            var cs = SystemManager.GetCommentsService();

            //instantiate comment filter
            var commentFilter = new CommentFilter();

            //gets the thread related to the blog post
            //var language = Thread.CurrentThread.CurrentUICulture.Name;
            //var threadKey = ControlUtilities.GetLocalizedKey(blogPost.Id, language);
            commentFilter.ThreadType.Add(typeof(BlogPost).FullName);
            //get the comment with the specified commentKey
            var comments = cs.GetComments(commentFilter).OrderByDescending(x => x.DateCreated).Take(3);
            ViewBag.Comments = comments;
            return View("Default");
        }
    }
}