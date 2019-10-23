using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class HomeController : Controller
    {
        private INorthwindRepository repository;

        public HomeController(INorthwindRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {

            var discounts = repository.Discounts.Where(d => d.EndTime.Date > DateTime.Now).OrderBy(d => d.EndTime).Take(3);
            return View(discounts);
        }

    } 
}
