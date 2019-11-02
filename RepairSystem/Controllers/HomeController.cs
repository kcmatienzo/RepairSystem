using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RepairSystem.Models;

namespace RepairSystem.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Registration(CarRegistration carRegistration)
        {
            if (ModelState.IsValid)
            {
                Repository.AddRegistration(carRegistration);
                return View("ThankYou", carRegistration);
            }
            else
            {
                return View();
            }

        }

        public ViewResult RegistrationList()
        {
            return View(Repository.Registrations
                .OrderBy(c => c.Owner));
        }

        public ViewResult ViewDetails(string id)
        {
            return View(Repository.Registrations
                .Where(c => c.LicensePlate == id));
        }
    }
}
