using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string ReleasingDate { get; set; }
        public string Genre { get; set; }
        public decimal Rating { get; set; }
        public int Price { get; set; }
        
    }
}