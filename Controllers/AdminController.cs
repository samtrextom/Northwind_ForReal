using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Controllers
{
    public class AdminController : Controller
    {
        //private UserManager<AppUser> userManager;

       // public AdminController(UserManager userManager)
        //{
        //    this.userManager = userManager;
       // }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }


    }
}
