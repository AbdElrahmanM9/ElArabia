using ElArabia.Data;
using ElArabia.Helper;
using ElArabia.Models;
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
            ViewBag.BrandsId = _Context.BrandsModel.Select(x => new SelectListItem()
            {
                Text = x.NameAr + "_" + x.NameEn,
                Value = x.Id.ToString(),
            });
            return View();
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

    }
}
