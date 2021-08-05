using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uppgift1.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateCustomer()
        {
            return View();
        }

        public IActionResult ReplaceCustomer()
        {
            return View();
        }

        public IActionResult UpdateCustomer()
        {
            return View();
        }

        public IActionResult DeleteCustomer()
        {
            return View();
        }
    }
}
