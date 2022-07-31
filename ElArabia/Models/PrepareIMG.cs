using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElArabia.Models
{
    public class PrepareIMG
    {
        public int Id { get; set; }
        public int ProductsDetailId { get; set; }
        public ProductsDetails ProductsDetail { get; set; }
        public string IMG { get; set; }
    }
}
