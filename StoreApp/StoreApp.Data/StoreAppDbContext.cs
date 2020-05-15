using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace StoreApp.Data
{
    public class StoreAppDbContext : DbContext
    {
        public StoreAppDbContext (DbContextOptions<StoreAppDbContext> options)
            : base(options)
        { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
    }
}
