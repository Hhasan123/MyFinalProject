using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db tabloları ile proje class larını baglamak
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");  
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
//LAPTOP-M3O4BQHI\SQLEXPRESS
//(localdb)\mssqllocaldb
//Yukarıdakilerden ilki MS SQL deki server adı aşağıdaki de Visual Studio daki server adıdır
// ve her ikisi de calismaktadir