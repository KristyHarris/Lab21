using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab21.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab21.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Registration registration)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(registration);
        }
    }
}
