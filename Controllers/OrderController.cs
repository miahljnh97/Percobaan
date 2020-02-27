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

        // [HttpPatch("{id}")]
        // public IActionResult Put(int id, Order_status status){
        //     var order = _context.Order.First(i => i.Id == id);
        //     order.Status = status;
        //     order.Updated_at = DateTime.Now;
        //     _context.SaveChanges();
        //     return Ok(order);
        // }
        [HttpPost]
        public IActionResult Post(int custId, status status, int driveId)
        {
            var order = new Orders
            {
                user_id = custId,
                status = status,
                driver_id = driveId,
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
