using Microsoft.AspNetCore.Mvc;
using Electronic_Learning_System.Models;
using System.Collections.Generic;


namespace Electronic_Learning_System.Controllers
{
    public class UserController
        : Controller
    {
        // C r e a t e
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User Hahahaa)
        {
            //Adds this User(v) to the database.
            return RedirectToAction("Details");
            //return View("Details");
        }
        // R e a d

        // Read a User out of the Database and display it on a web page.
        public IActionResult Details(int id)
        {
            // 1. Go to the database and retrieve User with the given id.
            User v = new User();
            v.DODID = 1;
            v.Password = "apples";
            v.ConfirmPassword = "apples";
            v.FirstName = "Miguel";
            v.LastName = "Deleon";
            v.Occupation = "HR";
            v.Title = "SGT";

            // 2. Display that User on a View.
           return View(v);

        }

        // U p d a t e
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // 1. Go to the database and retrieve User with the given id.
            User v = new User();
            v.DODID = 1;
            v.Password = "SolarWinds123-lol";
            v.ConfirmPassword = "SolarWinds123-lol";
            v.FirstName = "Miguel";
            v.LastName = "Deleon";
            v.Occupation = "HR";
            v.Title = "SGT";

            // 2. Display that User on a View.//
            return View(v);
        }
        [HttpPost]
        public IActionResult Edit(User v)
        {
            //Update the User(v) in the database - ignore for now
            return RedirectToAction("Details");
        }

        // D e l e t e



    }
}
