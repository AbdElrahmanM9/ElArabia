using ElArabia.Data;
using ElArabia.Helper;
using ElArabia.Models;
using ElArabia.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElArabia.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _Context;

        public AdminController(ApplicationDbContext Context)
        {
            _Context = Context;
        }
        public IActionResult Index()
        {
            var Brands = _Context.BrandsModel.ToList();

            return View(Brands);
        }
        public IActionResult _AddNewProduct()
        {
            ViewBag.BrandsId = _Context.BrandsModel.Select(x => new SelectListItem()
            {
                Text = x.NameAr + "_" + x.NameEn,
                Value = x.Id.ToString(),
            });
            return PartialView();
        }
        public ActionResult AddNewProduct([FromForm] Products Product, IFormFile upload)
        {

            if (ModelState.IsValid)
            {
                var UserN = User.Identity.Name;
                var UserId = _Context.User.FirstOrDefault(x => x.UserName == UserN);

                var product = new Products()
                {
                    NameAr = Product.NameAr,
                    NameEn = Product.NameEn,
                    Price = Product.Price,
                    Description = Product.Description,
                    IsActive = true,
                    IsDeleted = false,
                    BrandId = Product.BrandId
                };
                if (upload != null)
                {
                    product.Image = UploadImagesHelper.UploadImage(upload, "Images");
                }
                _Context.Products.Add(product);
                _Context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BrandsId = _Context.BrandsModel.Select(x => new SelectListItem()
            {
                Text = x.NameAr,
                Value = x.Id.ToString(),
            });
            return RedirectToAction("Index");

        }

        public ActionResult _AllProducts()
        {
            ViewBag.BrandsId = _Context.BrandsModel.Select(x => new SelectListItem()
            {
                Text = x.NameAr + "_" + x.NameEn,
                Value = x.Id.ToString(),
            });
            var Model = new ItemsListViewModel()
            {
                products = _Context.Products.Where(X => X.IsDeleted == false && X.IsActive == true).ToList(),
            };

            return PartialView("_AllProducts", Model);
        }
        public ActionResult DeleteItem(int ProductId)
        {
            Products Products = new Products();
            Products = _Context.Products.FirstOrDefault(x => x.Id == ProductId);
            Products.IsActive = false;
            Products.IsDeleted = true;

            _Context.Entry(Products).CurrentValues.SetValues(Products);
            _Context.SaveChanges();

            return RedirectToAction("_AllProducts");
        }
        public ActionResult _EditItem(int ProductId)
        {
            Products Products = new Products();
            CheeseViewModel CheeseViewModel = new CheeseViewModel();

            Products = _Context.Products.FirstOrDefault(x => x.Id == ProductId);
            CheeseViewModel.Id = Products.Id;
            CheeseViewModel.NameAr = Products.NameAr;
            CheeseViewModel.NameEn = Products.NameEn;
            ViewBag.BrandsId = Products.BrandId;
            CheeseViewModel.Image = Products.Image;
            CheeseViewModel.Description = Products.Description;
            CheeseViewModel.Price = Products.Price;

            return PartialView(CheeseViewModel);
        }
        public ActionResult EditProduct([FromForm] Products Product, IFormFile upload)
        {
            var UserN = User.Identity.Name;
            var UserId = _Context.User.FirstOrDefault(x => x.UserName == UserN);

            if (ModelState.IsValid)
            {
                Products Products = new Products();
                Products = _Context.Products.FirstOrDefault(x => x.Id == Product.Id);

                Products.Id = Product.Id;
                Products.NameAr = Product.NameAr;
                Products.NameEn = Product.NameEn;
                Products.Description = Product.Description;
                Products.IsActive = true;
                Products.IsDeleted = false;
                Products.BrandId = Products.BrandId;
                
                if (upload != null)
                {
                    Products.Image = UploadImagesHelper.UploadImage(upload, "Images");
                }
                _Context.Entry(Products).CurrentValues.SetValues(Products);
                _Context.SaveChanges();

                return RedirectToAction("_AllProducts");
            }

            ViewBag.BrandsId = _Context.BrandsModel.Select(x => new SelectListItem()
            {
                Text = x.NameAr,
                Value = x.Id.ToString(),
            });
            return RedirectToAction("Index");

        }
    }
}
