using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class ArticleViewModel
    {
        public int Id { get; set; }

        [Require]
        [StringLength(50)]
        public string Title { get; set; }

        [Require]
        public string Content { get; set; }

        public string AuthorId { get; set; }
    }
}