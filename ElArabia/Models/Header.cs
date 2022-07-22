using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElArabia.Models
{
    public class Header
    {
        public int Id { get; set; }
        public string IMG { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
