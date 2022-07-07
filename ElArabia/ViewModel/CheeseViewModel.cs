using ElArabia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElArabia.ViewModel
{
    public class CheeseViewModel
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int BrandId { get; set; }
        public BrandsModel Brand { get; set; }
    }
}
