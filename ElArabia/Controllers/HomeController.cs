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
            int Counter = 1;

            HomePageViewModel HomePageViewModel = new HomePageViewModel();
            HeaderViewModel header = new HeaderViewModel();

            var Header = _Context.Header.Where(x => x.IsActive == true && x.IsDeleted == false).ToList();
            foreach (var item in Header)
            {
                if (Counter == 1)
                {
                    header.IMG1 = item.IMG;
                }
                if (Counter == 2)
                {
                    header.IMG2 = item.IMG;
                }
                if (Counter == 3)
                {
                    header.IMG3 = item.IMG;
                }
                if (Counter == 4)
                {
                    header.IMG4 = item.IMG;
                }
                if (Counter == 5)
                {
                    header.IMG5 = item.IMG;
                }
                if (Counter == 6)
                {
                    header.IMG6 = item.IMG;
                }
                Counter++;
            }
            HomePageViewModel.Header = header;
            //HomePageViewModel.HomeModelOne = _Context.HomeModelOne.FirstOrDefault();
            //HomePageViewModel.HomeModelTwo = _Context.HomeModelTwo.FirstOrDefault();
            //HomePageViewModel.HomeModelThree = _Context.HomeModelThree.FirstOrDefault();
            HomePageViewModel.BrandsModel = _Context.BrandsModel.ToList();
            HomePageViewModel.Products = _Context.Products.Where(x => x.IsActive == true && x.IsDeleted == false).ToList();

            return View(HomePageViewModel);
        }

        public ActionResult _MoreDetials(string NameEn)
        {
            ItemsListViewModel ItemsListViewModel = new ItemsListViewModel();

            ItemsListViewModel.product = _Context.Products.Include(x => x.Brand).FirstOrDefault(x => x.NameEn.Contains(NameEn) || x.Brand.NameEn.Contains(NameEn));
            if (ItemsListViewModel.product != null)
            {
                ItemsListViewModel.products = _Context.Products.Where(x => x.BrandId == ItemsListViewModel.product.BrandId && x.IsDeleted == false && x.IsActive == true).ToList();
                foreach (var item in ItemsListViewModel.products)
                {
                    item.Prepare = item.Prepare != null ? item.Prepare : "#";
                }
                return PartialView(ItemsListViewModel);
            }

            return RedirectToAction("Index");

        }
        public ActionResult _Details(string NameEn, int? Id)
        {
            ItemsListViewModel ItemsListViewModel = new ItemsListViewModel();

            ItemsListViewModel.product = _Context.Products.Include(x => x.Brand).FirstOrDefault(x => x.NameEn.Contains(NameEn) || x.Brand.NameEn.Contains(NameEn) || x.Id == Id.Value);
            var ProductId = ItemsListViewModel.product.Id;
            if (ItemsListViewModel.product != null)
            {
                ItemsListViewModel.ProductsDetails = _Context.ProductsDetails.Where(x => x.ProductId == ProductId && x.IsDeleted == false && x.IsActive == true).ToList();
                if (ItemsListViewModel.ProductsDetails != null)
                {
                    foreach (var item in ItemsListViewModel.ProductsDetails)
                    {
                        item.Prepare = item.Prepare != null ? item.Prepare : "#";
                    }
                }

                var ProductsDetailId = ItemsListViewModel.ProductsDetails.FirstOrDefault().Id;

                ItemsListViewModel.PrepareIMG = _Context.PrepareIMG.Where(x => x.ProductsDetailId == ProductsDetailId).ToList();

                return PartialView(ItemsListViewModel);
            }

            return RedirectToAction("Index");

        }
        public ActionResult _DetialsByDetial(int Id)
        {
            ItemsListViewModel ItemsListViewModel = new ItemsListViewModel();

            ItemsListViewModel.ProductsDetail = _Context.ProductsDetails.Include(x => x.Product).FirstOrDefault(x => x.Id == Id);
            var ProductId = ItemsListViewModel.ProductsDetail.ProductId;
            if (ItemsListViewModel.ProductsDetail != null)
            {
                ItemsListViewModel.products = _Context.Products.Where(x => x.Id == ProductId && x.IsDeleted == false && x.IsActive == true).ToList();
                if (ItemsListViewModel.ProductsDetail != null)
                {
                    var Prepare = ItemsListViewModel.ProductsDetail.Prepare;
                    ItemsListViewModel.ProductsDetail.Prepare = Prepare != null ? Prepare : "#";
                }
                ItemsListViewModel.ProductsDetails = _Context.ProductsDetails.Where(x => x.ProductId == ProductId);
                var ProductsDetailId = ItemsListViewModel.ProductsDetail.Id;

                ItemsListViewModel.PrepareIMG = _Context.PrepareIMG.Where(x => x.ProductsDetailId == ProductsDetailId).ToList();

                return PartialView(ItemsListViewModel);
            }

            return RedirectToAction("Index");

        }

        public ActionResult _AllKindsCheese()
        {
            List<Products> Products = new List<Products>();

            //var Brands = _Context.BrandsModel.ToList();

            //foreach (var item in Brands)
            //{
            //    Products Product = new Products();
            //    var Pro = _Context.Products.FirstOrDefault(x => x.BrandId == item.Id);
            //    Product.NameEn = Pro != null ? Pro.NameEn : "";
            //    Product.NameAr = Pro != null ? Pro.NameAr : "";
            //    Product.Image = Pro != null ? Pro.Image : "";
            //    if (Pro != null)
            //    {
            //        Products.Add(Product);
            //    }
            //}

            Products = _Context.Products.Where(x => x.IsActive == true && x.IsDeleted == false).ToList();
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
