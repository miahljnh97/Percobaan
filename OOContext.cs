using System;
using Microsoft.EntityFrameworkCore;
using TryoutFebruari.Models;

namespace TryoutFebruari
{
    public class OnlineContext : DbContext
    {
        public OnlineContext(DbContextOptions<OnlineContext> options) : base(options) { }

        public DbSet<Customers> customers { get; set; }
        public DbSet<Orders> orders { get; set; }
        public DbSet<Order_items> order_Items { get; set; }
        public DbSet<Drivers> drivers { get; set; }
        public DbSet<Products> products { get; set; }
    }

}