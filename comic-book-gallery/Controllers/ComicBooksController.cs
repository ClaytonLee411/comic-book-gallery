using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comic_book_gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        //Method return type ActionResult is almost always used
       public ActionResult Detail ()
       {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return new RedirectResult("/");
            }
            return Content("Hello form the comic books control");
       }
    }
}