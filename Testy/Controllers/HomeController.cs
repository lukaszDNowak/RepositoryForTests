using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Testy.Methods;


namespace Testy.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Sum(long? a,long? b)
        {
            if(a!=null && b!=null)
            {
                ViewBag.Sum = "Wynik : "+ Calculate.SumScore(a, b);
            }
            else 
            {
                ViewBag.Error = "Uzupełnij brakujące pola prawidłowymi cyframi !";
            }
            return View();
        }

      
        public ActionResult About()
        {
            ViewBag.Message = "Strona została utworzona na potrzeby zaliczenia przedmiotu : Testy i kontrola jakości oprogramowania ";
              
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}