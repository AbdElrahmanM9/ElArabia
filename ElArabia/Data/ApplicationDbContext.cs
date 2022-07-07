using ElArabia.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElArabia.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<BrandsModel> BrandsModel { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Products> Products { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
