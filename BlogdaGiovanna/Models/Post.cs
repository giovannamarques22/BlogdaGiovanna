using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogdaGiovanna.Models
{
    public class Post
    {
        public int id { get; set; }

        [Required]
        [StringLength(500)]

        public string Title { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime? DateUpdate { get; set; }

        [Required]
        [StringLength(3000)]
        [AllowHtml]
        public string PostingBody { get; set; }

        public byte [] image { get; set; }
    }
}