using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: /user/add
        public IActionResult Add()
        {
            return View();
        }
        // POST: /user
        [HttpPost("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string username, string email, string verify)
        {
            if (!String.IsNullOrWhiteSpace(verify) && verify.Equals(newUser.Password))
            {
                ViewBag.newUser = newUser;
                return View("Index");
            } else
            {
                ViewBag.passwordMismatch = true;
                ViewBag.Username = username;
                ViewBag.Email = email;
                return View("Add");
            }
        }
    }
}
