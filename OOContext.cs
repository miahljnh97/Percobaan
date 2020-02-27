using System;
using Microsoft.EntityFrameworkCore;
using TryoutFebruari.Models;

namespace TryoutFebruari
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options) { }

        public DbSet<Customers> customers { get; set; }
    }

    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options) { }

        public DbSet<Orders> orders { get; set; }
    }

    public class OrderItemContext : DbContext
    {
        public OrderItemContext(DbContextOptions<OrderItemContext> options) : base(options) { }

        public DbSet<Order_items> order_Items { get; set; }
    }

    public class DriversContext : DbContext
    {
        public DriversContext(DbContextOptions<DriversContext> options) : base(options) { }

        public DbSet<Drivers> drivers { get; set; }
    }
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet<Products> products { get; set; }
    }
}
