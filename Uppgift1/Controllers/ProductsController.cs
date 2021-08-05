using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uppgift1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateProduct()
        {
            return View();
        }

        public IActionResult ReplaceProduct()
        {
            return View();
        }

        public IActionResult UpdateProduct()
        {
            return View();
        }

        public IActionResult DeleteProduct()
        {
            return View();
        }
    }
}
