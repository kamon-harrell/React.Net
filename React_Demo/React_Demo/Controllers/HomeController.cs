﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using React_Demo.Models;

namespace React_Demo.Controllers
    {
    public class HomeController : Controller
        {
        private static readonly IList<CommentModel> _comments;

            static HomeController()
                {
                _comments = new List<CommentModel>
                {
                    new CommentModel
                    {
                        Id = 1,
                        Author = "Daniel Lo Nigro",
                        Text = "Hello ReactJS.NET World!"
                    },
                    new CommentModel
                    {
                        Id = 2,
                        Author = "Pete Hunt",
                        Text = "This is one comment"
                    },
                    new CommentModel
                    {
                        Id = 3,
                        Author = "Jordan Walke",
                        Text = "This is *another* comment"
                    },
                };
            }

        public ActionResult Index()
            {
            return View();
            }

        public ActionResult Comments()
            {
            return Json(_comments, JsonRequestBehavior.AllowGet);
            }

        [HttpPost]
        public ActionResult AddComment(CommentModel comment)
            {
            // Create a fake ID for this comment
            comment.Id = _comments.Count + 1;
            _comments.Add(comment);
            return Content("Success :)");
            }
        }
    }