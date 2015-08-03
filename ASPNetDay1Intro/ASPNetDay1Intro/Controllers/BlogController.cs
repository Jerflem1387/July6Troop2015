﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetDay1Intro.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult GetEntryByDate(DateTime entryDate)
        {
            return Content("You requested the blog entry for date " + entryDate.ToLongDateString());
        }

        public ActionResult GetEntryById(int entryId)
        {
            return Content("Your requested the blog entry id " + entryId.ToString());
        }
    }
}