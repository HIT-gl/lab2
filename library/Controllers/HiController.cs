﻿using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HiController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        /*      public string Index()
              {
                  return "This is my <b>default</b> action...";
              }*/
        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        /*   public string Welcome()
           {
               return "This is the Welcome action method...";
           }*/
        /*    public string Welcome(string name, int id = 1)
            {
                return HttpUtility.HtmlEncode("Hello " + name + ", id is: " + id);
            }*/
        public ActionResult Welcome(string name, int id = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.Id = id;
            return View();
        }
    }
}