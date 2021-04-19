using Microsoft.AspNetCore.Mvc;
using RegistrationDemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationDemoMVC.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Post(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Index", model);
            }
            return View("Index");
        }
    }
}