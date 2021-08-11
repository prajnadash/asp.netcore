using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;

namespace BookStore.App.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "I am from index method";
        //}

        public ViewResult Index()
        {
            ViewBag.Title = 123;
            dynamic data = new ExpandoObject();
            data.Id = 1;
            data.Name = "John";
            ViewBag.Data = data;

            var obj = new { id = 1, Name = "John" };
            return View(obj);
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
