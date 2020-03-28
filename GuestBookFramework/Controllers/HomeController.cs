using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GuestBookFramework.Data;
using GuestBookFramework.Models.Entities;

namespace GuestBookFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly GuestBookContext _context;

        public HomeController(GuestBookContext context)
        {
            _context = context;
        }


        public ActionResult CommentAdd(string username, string coommentText)
        {
            _context.Comments.Add(new Comment { Date = DateTime.Now, Username = username, Text = coommentText });
            _context.SaveChanges();
            return PartialView(_context.Comments.ToList<Comment>());
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}