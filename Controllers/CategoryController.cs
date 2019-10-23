using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class CategoryController : Controller
    {
        private INorthwindRepository repository;

        public CategoryController(INorthwindRepository repository)
        {
            this.repository = repository;
        }
    }
}