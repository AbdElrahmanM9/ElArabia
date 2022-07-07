using ElArabia.Data;
using ElArabia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ElArabia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _Context;

        public HomeController(ApplicationDbContext Context, ILogger<HomeController> logger)
        {
            _Context = Context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var Brands = _Context.BrandsModel.ToList();
            return View(Brands);
        }

        public ActionResult _MoreDetials(int BrandId) 
        {
            var Products = _Context.Products.Where(x => x.BrandId == BrandId).ToList();
            return PartialView(Products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
