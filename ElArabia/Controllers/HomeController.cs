using ElArabia.Data;
using ElArabia.Models;
using ElArabia.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public ActionResult _MoreDetials(string NameEn)
        {
            ItemsListViewModel ItemsListViewModel = new ItemsListViewModel();

            ItemsListViewModel.product = _Context.Products.Include(x=>x.Brand).FirstOrDefault(x => x.NameEn.Contains(NameEn)||x.Brand.NameEn.Contains(NameEn));
            if (ItemsListViewModel.product != null)
            {
                ItemsListViewModel.products = _Context.Products.Where(x => x.BrandId == ItemsListViewModel.product.BrandId).ToList();

                return PartialView(ItemsListViewModel);
            }

            return RedirectToAction("Index");

        }
        public ActionResult _AllKindsCheese()
        {
            List<Products> Products = new List<Products>();
            var Brands = _Context.BrandsModel.ToList();

            foreach (var item in Brands)
            {
                Products Product = new Products();
                var Pro = _Context.Products.FirstOrDefault(x => x.BrandId == item.Id);
                Product.NameEn = Pro != null ? Pro.NameEn : "";
                Product.NameAr = Pro != null ? Pro.NameAr : "";
                Product.Image = Pro != null ? Pro.Image : "";
                if (Pro != null)
                {
                    Products.Add(Product);
                }
            }
            return PartialView(Products);
        }
        public async Task<IActionResult> Search(string searchString)
        {
            var Items = from m in _Context.Products
                        select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                Items = Items.Where(s => s.NameAr.Contains(searchString) || s.NameEn.Contains(searchString) || s.Description.Contains(searchString));
            }

            var ItemsModel = new ItemsListViewModel
            {
                products = await Items.ToListAsync()
            };

            return PartialView("_ResultSearch", ItemsModel);
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
