using ElArabia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElArabia.ViewModel
{
    public class HomePageViewModel
    {
        public List<BrandsModel> BrandsModel { get; set; }
        public List<Products> Products { get; set; }
        public HeaderViewModel Header { get; set; }
        public HomeModelOne HomeModelOne { get; set; }
        public HomeModelTwo HomeModelTwo { get; set; }
        public HomeModelThree HomeModelThree { get; set; }

    }
}
