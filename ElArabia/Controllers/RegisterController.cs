using ElArabia.Data;
using ElArabia.Models;
using ElArabia.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElArabia.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ApplicationDbContext _Context;

        public RegisterController(UserManager<User> userManager, SignInManager<User> signInManager, ApplicationDbContext Context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _Context = Context;
        }
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.username,
                    Email = model.Email,
                    EmailConfirmed = true,
                    Type = "User",
                    PhoneNumber = model.Phonenumber.ToString(),
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToAction("Login", "Login");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                ViewBag.Error = "Invalid Login Attempt";

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }

            ViewBag.Error = "The password and confirmation password do not match";

            ModelState.AddModelError(string.Empty, "The password and confirmation password do not match");
            return View(model);
        }

    }
}
