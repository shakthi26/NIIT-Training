using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        List<Movie> l = new List<Movie>();
        public ActionResult GetMovieDetails()
        {
            Movie m1 = new Movie();
            m1.Title = "John Wick";
            m1.ReleasingDate = "Jan 21 2021";
            m1.Genre = "Action";
            m1.Rating = 4.5m;
            m1.Price = 50000000;

            l.Add(m1);

            Movie m2 = new Movie();
            m2.Title = "Taken";
            m2.ReleasingDate = "Feb 21 2021";
            m2.Genre = "Thriller";
            m2.Rating = 4.6m;
            m2.Price = 40000000;

            l.Add(m2);

            Movie m3 = new Movie();
            m3.Title = "The Notebook";
            m3.ReleasingDate = "Mar 21 2021";
            m3.Genre = "Romance";
            m3.Rating = 4.2m;
            m3.Price = 20000000;

            l.Add(m3);

            Movie m4 = new Movie();
            m4.Title = "Tarzan";
            m4.ReleasingDate = "Apr 21 2021";
            m4.Genre = "Drama";
            m4.Rating = 4.3m;
            m4.Price = 3000000;

            l.Add(m4);

            Movie m5 = new Movie();
            m5.Title = "Avengers";
            m5.ReleasingDate = "May 21 2021";
            m5.Genre = "Family";
            m5.Rating = 4.8m;
            m5.Price = 80000000;

            l.Add(m5);

            return View(l);
        }
    }
}