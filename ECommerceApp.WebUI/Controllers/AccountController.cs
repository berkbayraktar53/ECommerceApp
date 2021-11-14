using ECommerceApp.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApp.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == null || password == null)
            {
                return View();
            }
            var user = _userService.GetByUser(username, password);
            if (username == user.UserName && password == user.Password)
            {
                HttpContext.Session.SetString("UserName", user.FirstName + " " + user.LastName);
                return RedirectToAction("Complete", "Cart");
            }
            return RedirectToAction("Index", "Product");
        }
    }
}