﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class ContactController : Controller
    {
        private INorthwindRepository repository;

        public ContactController(INorthwindRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            if(ModelState.IsValid)
            {
                repository.AddContact(contact);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}