using System;
namespace TryoutFebruari.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string full_name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime created_at { get; set; }
        public DateTime update_at { get; set; }
    }

    public class Orders
    {
        public int Id { get; set; }
        public int user_id { get; set; }
        public string status { get; set; }
        public int driver_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime update_at { get; set; }
    }

    public class Order_items
    {
        public int order_id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
    }

    public class Drivers
    {
        public int Id { get; set; }
        public string full_name { get; set; }
        public string phone_number { get; set; }
        public DateTime created_at { get; set; }
        public DateTime update_at { get; set; }
    }

    public class Products
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public DateTime created_at { get; set; }
        public DateTime update_at { get; set; }
    }
}
