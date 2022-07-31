using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElArabia.Models
{
    public class ProductsDetails
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Image { get; set; }
        public int ProductId { get; set; }
        public Products Product { get; set; }
        public string Price { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string Description { get; set; }
        public string Prepare { get; set; }
        //public int? PrepareIMGId { get; set; }
        //public PrepareIMG PrepareIMG { get; set; }
    }
}
