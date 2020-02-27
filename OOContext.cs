using System;
using Microsoft.EntityFrameworkCore;
using TryoutFebruari.Models;

namespace TryoutFebruari
{
    public class OnlineOrderContext : DbContext
    {
        public OnlineOrderContext(DbContextOptions<OnlineOrderContext> options) : base(options) { }

        public DbSet<Customers> customers { get; set; }
        //public DbSet<Orders> orders { get; set; }
        //public DbSet<Order_items> order_Items { get; set; }
        //public DbSet<Drivers> drivers { get; set; }
        //public DbSet<Products> products { get; set; }

    }
}
