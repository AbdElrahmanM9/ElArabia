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
            var User = GetUser();
            if (User == true)
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
                HomePageViewModel.HomeModelOne = _Context.HomeModelOne.FirstOrDefault();
                HomePageViewModel.HomeModelTwo = _Context.HomeModelTwo.FirstOrDefault();
                HomePageViewModel.HomeModelThree = _Context.HomeModelThree.FirstOrDefault();
                HomePageViewModel.BrandsModel = _Context.BrandsModel.ToList();

                return View(HomePageViewModel);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }
        public IActionResult _AddNewProduct()
        {
            var User = GetUser();
            if (User == true)
            {
                ViewBag.BrandsId = _Context.BrandsModel.Select(x => new SelectListItem()
                {
                    Text = x.NameAr + "_" + x.NameEn,
                    Value = x.Id.ToString(),
                });
                return PartialView();
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }
        public ActionResult AddNewProduct([FromForm] Products Product, IFormFile upload)
        {
            var User = GetUser();
            if (User == true)
            {
                if (ModelState.IsValid)
                {
                    var product = new Products()
                    {
                        NameAr = Product.NameAr,
                        NameEn = Product.NameEn,
                        Price = Product.Price,
                        Description = Product.Description,
                        Prepare = Product.Prepare,
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
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        public ActionResult _AllProducts()
        {
            var User = GetUser();
            if (User == true)
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
            else
            {
                return RedirectToAction("Login", "Login");
            }
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
            CheeseViewModel.Prepare = Products.Prepare;
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
                Products.Prepare = Product.Prepare;
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
        public ActionResult _EditModelOne()
        {
            HomeModelOne HomeModelOne = new HomeModelOne();
            HomeModelOne = _Context.HomeModelOne.FirstOrDefault();

            return PartialView(HomeModelOne);
        }
        public ActionResult SaveModelOne([FromForm] HomeModelOne HomeModelOne, IFormFile upload)
        {
            if (ModelState.IsValid)
            {
                HomeModelOne HomeOne = new HomeModelOne();
                HomeOne = _Context.HomeModelOne.FirstOrDefault(x => x.Id == HomeModelOne.Id);

                HomeOne.Id = HomeOne.Id;
                HomeOne.Title = HomeModelOne.Title;
                HomeOne.Description = HomeModelOne.Description;


                if (upload != null)
                {
                    HomeOne.IMG = UploadImagesHelper.UploadImage(upload, "Images");
                }
                _Context.Entry(HomeOne).CurrentValues.SetValues(HomeOne);
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

        public ActionResult _EditModelTwo()
        {
            HomeModelTwo HomeModelTwo = new HomeModelTwo();
            HomeModelTwo = _Context.HomeModelTwo.FirstOrDefault();

            return PartialView(HomeModelTwo);
        }
        public ActionResult SaveModelTwo([FromForm] HomeModelTwo HomeModelTwo, IFormFile upload)
        {
            if (ModelState.IsValid)
            {
                HomeModelTwo HomeTwo = new HomeModelTwo();
                HomeTwo = _Context.HomeModelTwo.FirstOrDefault(x => x.Id == HomeModelTwo.Id);

                HomeTwo.Id = HomeTwo.Id;
                HomeTwo.Title = HomeModelTwo.Title;
                HomeTwo.Description = HomeModelTwo.Description;


                if (upload != null)
                {
                    HomeTwo.IMG = UploadImagesHelper.UploadImage(upload, "Images");
                }
                _Context.Entry(HomeTwo).CurrentValues.SetValues(HomeTwo);
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

        public ActionResult _EditModelThree()
        {
            HomeModelThree HomeModelThree = new HomeModelThree();
            HomeModelThree = _Context.HomeModelThree.FirstOrDefault();

            return PartialView(HomeModelThree);
        }
        public ActionResult SaveModelThree([FromForm] HomeModelThree HomeModelThree, IFormFile upload)
        {
            if (ModelState.IsValid)
            {
                HomeModelThree HomeThree = new HomeModelThree();
                HomeThree = _Context.HomeModelThree.FirstOrDefault(x => x.Id == HomeModelThree.Id);

                HomeThree.Id = HomeThree.Id;
                HomeThree.Title = HomeModelThree.Title;
                HomeThree.Description = HomeModelThree.Description;


                if (upload != null)
                {
                    HomeThree.IMG = UploadImagesHelper.UploadImage(upload, "Images");
                }
                _Context.Entry(HomeThree).CurrentValues.SetValues(HomeThree);
                _Context.SaveChanges();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
        public ActionResult _EditHeader()
        {
            var User = GetUser();
            if (User == true)
            {
                var Header = _Context.Header.Where(x => x.IsActive == true && x.IsDeleted == false).ToList();
                return PartialView(Header);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }
        public ActionResult DeleteHeaderPhoto(int Id)
        {
            Header Header = new Header();
            Header = _Context.Header.FirstOrDefault(x => x.Id == Id);
            Header.IsActive = false;
            Header.IsDeleted = true;

            _Context.Entry(Header).CurrentValues.SetValues(Header);
            _Context.SaveChanges();

            return RedirectToAction("_EditHeader");
        }
        public ActionResult AddNewPhotoInHeader(IFormFile upload)
        {
            if (upload != null)
            {
                Header Header = new Header();
                Header.IsActive = true;
                Header.IsDeleted = false;
                Header.IMG = UploadImagesHelper.UploadImage(upload, "Images");

                _Context.Add(Header);
                _Context.SaveChanges();

                return RedirectToAction("_EditHeader");
            }
            return RedirectToAction("_EditHeader");
        }
        public bool GetUser()
        {
            var UserN = User.Identity.Name;
            var UserId = _Context.User.FirstOrDefault(x => x.UserName == UserN);

            if (UserId != null)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }
    }
}
