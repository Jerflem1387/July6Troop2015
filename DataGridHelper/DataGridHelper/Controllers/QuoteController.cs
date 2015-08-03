using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataGridHelper.Controllers
{
    public class QuoteController : Controller
    {
        // GET: Quote
        
        [ChildActionOnly]
        public ActionResult GetQuote()
        {
            Random rand = new Random();
            List<string> quotes = new List<string>
            {
                "We grow small trying to be great.",
                "We love even when our love is not requited.",
                "Don't you know that every perfect life would mean the end of art?",
                "Rose is a rose is a rose is a rose",
                "We made too many wrong mistakes."

            };
            var randPos = rand.Next(quotes.Count - 1);
            string RandomQuote = quotes[randPos];



            return PartialView("_Quote", RandomQuote);
        }
    }
}