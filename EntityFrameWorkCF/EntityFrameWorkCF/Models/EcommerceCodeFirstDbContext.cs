using EntityFrameworkDBFApi.Models.entityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWorkCF.Models
{
    public class EcommerceCodeFirstDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }

        public DbSet<Products> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=EcommerceCodeFirstDb;Trusted_Connection=True;"); }
    }
}
