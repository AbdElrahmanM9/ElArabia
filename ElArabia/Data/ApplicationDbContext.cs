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
        public DbSet<Header> Header { get; set; }
        public DbSet<ProductsDetails> ProductsDetails { get; set; }
        public DbSet<PrepareIMG> PrepareIMG { get; set; }

        //public DbSet<HomeModelOne> HomeModelOne { get; set; }
        //public DbSet<HomeModelTwo> HomeModelTwo { get; set; }
        //public DbSet<HomeModelThree> HomeModelThree { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
