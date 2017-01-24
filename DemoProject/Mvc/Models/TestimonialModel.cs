using System;
using System.Linq;

namespace SitefinityWebApp.Mvc.Models
{
    public class TestimonialModel
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }
        public string Client_Name { get; set; }
        public string Designation { get; set; }
        public string Description { get; set; }
        public string Image_Path { get; set; }
    }
}