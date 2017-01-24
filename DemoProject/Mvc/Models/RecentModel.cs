using System;
using System.Linq;

namespace SitefinityWebApp.Mvc.Models
{
    public class RecentModel
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }
        public string Title { get; set; }
        public string Portfolio_Name { get; set; }
        public string Portfolio_Photo_Path { get; set; }
        public string Portfolio_Description { get; set; }
    }
}