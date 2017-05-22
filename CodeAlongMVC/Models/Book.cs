using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeAlongMVC.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
    }
}