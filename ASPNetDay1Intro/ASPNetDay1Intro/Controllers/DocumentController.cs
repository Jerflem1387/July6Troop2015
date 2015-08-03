using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetDay1Intro.Controllers
{
    public class DocumentController : Controller
    {
        // GET: Document
        public ActionResult GetDocument(string path)
        {
            return View();
        }
    }
}