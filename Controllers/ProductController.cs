using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class ProductController : Controller
    {
        private INorthwindRepository repository;

        public ProductController(INorthwindRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Category()
        {
            var categories = repository.Categories.OrderBy(c => c.CategoryName);

            return View(categories);
        }

        public IActionResult Index(String id)
        {
            var products = repository.Products;

            if(id!=null)
            {
                products = repository.Products.Where(p => p.CategoryId == id && p.Discontinued == false).OrderBy(p => p.ProductName);
            }
            return View(products);
        }

        public IActionResult CurentDiscounts()
        {
            var discounts = repository.Discounts.Where(d => d.EndTime.Date > DateTime.Now && d.StartTime.Date < DateTime.Now).OrderBy(d => d.EndTime);

            return View(discounts);
        }


    }
}