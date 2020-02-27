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
    [Route("orders")]
    public class OrderController : Controller
    {
        private readonly OnlineContext _context;

        public OrderController(OnlineContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var order = _context.orders;

            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = order
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var order = _context.orders.First(i => i.Id == id);

            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = order
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var order = _context.orders.First(i => i.Id == id);

            _context.orders.Remove(order);
            _context.SaveChanges();
            return Ok(order);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Orders orderput)
        {
            var order = _context.orders.First(i => i.Id == id);

            order.user_id = orderput.user_id;
            order.status = orderput.status;
            order.driver_id = orderput.driver_id;
            order.created_at = orderput.created_at;
            order.update_at = DateTime.Now;

            _context.orders.Update(order);
            _context.SaveChanges();
            return Ok(order);
        }

        [HttpPost]
        public IActionResult Post(Orders order)
        {
            order = new Orders
            {
                user_id = order.user_id,
                status = order.status,
                driver_id = order.driver_id,
                created_at = DateTime.Now,
                update_at = DateTime.Now
            };
            _context.orders.Add(order);
            _context.SaveChanges();
            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = order
            });
        }
    }
}
