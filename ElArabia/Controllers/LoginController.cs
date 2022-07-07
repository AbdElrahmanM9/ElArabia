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
    public class LoginController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ApplicationDbContext _Context;

        public LoginController(UserManager<User> userManager, SignInManager<User> signInManager, ApplicationDbContext Context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _Context = Context;
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel user)
        {
            if (ModelState.IsValid)
            {
                var User = await _userManager.FindByEmailAsync(user.Email);
                if (User != null)
                {
                    var result = await _signInManager.CheckPasswordSignInAsync(User, user.Password, false);

                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(User, isPersistent: false);

                        var UserId = _Context.User.FirstOrDefault(x => x.Email == user.Email);
                        if (UserId.Type == "Admin")
                        {
                            return RedirectToAction("Index", "Admin");
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                }
                else
                {
                    ViewBag.Error = "User Not Found";
                    ModelState.AddModelError(string.Empty, "User Not Found");
                }
            }
            return View(user);
        }

    }
}
