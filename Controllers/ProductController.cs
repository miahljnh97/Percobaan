using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TryoutFebruari.Models;

namespace TryoutFebruari.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : Controller
    {
        private readonly OnlineContext _context;

        public ProductController(OnlineContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var product = _context.products;

            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = product
            });
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _context.products.First(i => i.Id == id);

            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = product
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _context.products.First(i => i.Id == id);

            _context.products.Remove(product);
            _context.SaveChanges();
            return Ok(product);
        }

        // [HttpPatch("{id}")]
        // public IActionResult Put(int id, Order_status status){
        //     var order = _context.Order.First(i => i.Id == id);
        //     order.Status = status;
        //     _context.SaveChanges();
        //     return Ok(order);
        // }
        [HttpPost]
        public IActionResult Post(string name, int price)
        {
            var product = new Products
            {
                name = name,
                price = price,
                created_at = DateTime.Now,
                update_at = DateTime.Now
            };
            _context.products.Add(product);
            _context.SaveChanges();
            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = product
            });
        }
    }
}
