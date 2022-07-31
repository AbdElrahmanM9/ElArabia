using ElArabia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElArabia.ViewModel
{
    public class ItemsListViewModel
    {
        public IEnumerable<Products> products { get; set; }
        public IEnumerable<ProductsDetails> ProductsDetails { get; set; }
        public ProductsDetails ProductsDetail { get; set; }
        public Products product { get; set; }
        public List<PrepareIMG> PrepareIMG { get; set; }
        public IEnumerable<SuggestionViewModel> SuggestionViewModel { get; set; }

    }
}
