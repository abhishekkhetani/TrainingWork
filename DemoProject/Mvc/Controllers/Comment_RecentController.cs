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
            var model = new Comment_RecentModel();

            TaxonomyManager taxonomyManager = TaxonomyManager.GetManager();
            BlogsManager blogsManager = BlogsManager.GetManager();

            var blogs = blogsManager.GetBlogPosts();

            foreach (var blog in blogs)
            {
                var comments = blog.Comments.ToList();
            }

            List<Comment_RecentModel> comment_RecentList = new List<Comment_RecentModel>();
           
            return View("Default", comment_RecentList);
        }
    }
}