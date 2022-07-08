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
        public Products product { get; set; }
        public IEnumerable<SuggestionViewModel> SuggestionViewModel { get; set; }

    }
}
