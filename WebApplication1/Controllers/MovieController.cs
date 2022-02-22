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
        public MovieController()
        {
            Movie m1 = new Movie();
            m1.ID = 101;
            m1.Title = "John Wick";
            m1.ReleasingDate = "Jan 21 2021";
            m1.Genre = "Action";
            m1.Rating = 4.5m;
            m1.Price = 500;

            l.Add(m1);

            Movie m2 = new Movie();
            m2.ID = 102;
            m2.Title = "Don't Breathe";
            m2.ReleasingDate = "Feb 21 2021";
            m2.Genre = "Thriller";
            m2.Rating = 4.6m;
            m2.Price = 400;

            l.Add(m2);

            Movie m3 = new Movie();
            m3.ID = 103;
            m3.Title = "The Notebook";
            m3.ReleasingDate = "Mar 21 2021";
            m3.Genre = "Romance";
            m3.Rating = 4.2m;
            m3.Price = 250;

            l.Add(m3);

            Movie m4 = new Movie();
            m4.ID = 104;
            m4.Title = "Tarzan";
            m4.ReleasingDate = "Apr 21 2021";
            m4.Genre = "Drama";
            m4.Rating = 4.3m;
            m4.Price = 300;

            l.Add(m4);

            Movie m5 = new Movie();
            m5.ID = 105;
            m5.Title = "Interstellar";
            m5.ReleasingDate = "May 21 2021";
            m5.Genre = "Sci-Fi";
            m5.Rating = 4.8m;
            m5.Price = 800;

            l.Add(m5);
        }
        public ActionResult GetMovieDetails(List<Movie> l1)
        {

            if (l1 == null)
            {
                l1 = l;
            }

            return View(l1);
        }

        [HttpGet]
        public ActionResult ModifyMovie(int ID)
        {
            var mv = l.Where(x => x.ID == ID).FirstOrDefault();
            return View(mv);
        }

        [HttpPost]
        public ActionResult ModifyMovie(Movie mv1)
        {
            var mv = l.Where(x => x.ID == mv1.ID).FirstOrDefault();
            if (mv != null)
            {
                mv.Title = mv1.Title;
                mv.ReleasingDate = mv1.ReleasingDate;
                mv.Genre = mv1.Genre;
                mv.Rating = mv1.Rating;
                mv.Price = mv1.Price;
            }
            return View("GetMovieDetails",l);
        }
    }
}