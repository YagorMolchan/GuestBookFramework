using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GuestBookFramework.Data;
using GuestBookFramework.Models.Entities;
using GuestBookFramework.Models.ViewModels;


namespace GuestBookFramework.Controllers
{
    public class CommentController : Controller
    {
        private readonly GuestBookContext _context;

        public CommentController(GuestBookContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CommentViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Comments.Add(new Comment { Date = DateTime.Now, Username = model.Username, Text = model.Text });
                _context.SaveChanges();
                //var comments = GetComments();
                //return PartialView(comments);
            }
            else
            {
                ModelState.AddModelError("", "Ошибка ввода!");
            }
            return View(model);
        }


        [HttpPost]
        public ActionResult List(string username,string commentText)
        {
            _context.Comments.Add(new Comment { Date = DateTime.Now, Username = username, Text = commentText });
            _context.SaveChanges();
            return PartialView(_context.Comments.ToList<Comment>());
        }
    }
}