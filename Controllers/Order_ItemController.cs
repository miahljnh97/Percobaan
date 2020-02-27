using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TryoutFebruari.Models;

namespace TryoutFebruari.Controllers
{
    [ApiController]
    [Route("orderItems")]
    public class OrderItemController : Controller
    {
        private readonly OnlineContext _context;

        public OrderItemController(OnlineContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var order_item = _context.order_Items;

            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = order_item
            });
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var order_item = _context.order_Items.First(i => i.Id == id);

            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = order_item
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var order_item = _context.order_Items.First(i => i.Id == id);

            _context.order_Items.Remove(order_item);
            _context.SaveChanges();
            return Ok(order_item);
        }

        // [HttpPatch("{id}")]
        // public IActionResult Put(int id, Order_status status){
        //     var order = _context.Order.First(i => i.Id == id);
        //     order.Status = status;
        //     _context.SaveChanges();
        //     return Ok(order);
        // }
        [HttpPost]
        public IActionResult Post(int orderId, int productId, int quantity = 1)
        {
            var order_item = new Order_items
            {
                order_id = orderId,
                product_id = productId,
                quantity = quantity
            };
            _context.order_Items.Add(order_item);
            _context.SaveChanges();
            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = order_item
            });
        }
    }
}
