using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public class NortwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Server=DESKTOP-7NTL1A1\SQLEXPRESS;Database=NORTHWND;Trusted_Connection=True"); //DB bağlandım.
        }
        public DbSet<Product> Products { get; set; }
    }
}
