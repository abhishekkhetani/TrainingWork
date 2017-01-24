using System;
using System.Collections.Generic;
using System.Linq;

namespace SitefinityWebApp.Mvc.Models
{
    public class CategoriesModel
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }
        public List<string> Category_Name { get; set; }
        public string Portfolio_Name { get; set; }
        public string Portfolio_Photo_Path { get; set; }
        public string Portfolio_Description { get; set; }

        //public List<string> Categories { get; set; }
        }
}