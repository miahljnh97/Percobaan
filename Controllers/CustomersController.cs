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
    [Route("customers")]
    public class CustomerController : Controller
    {
        private readonly OnlineContext _context;

        public CustomerController(OnlineContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var customer = _context.customers;

            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = customer
            });
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customer = _context.customers.First(i => i.Id == id);

            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = customer
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var customer = _context.customers.First(i => i.Id == id);

            _context.customers.Remove(customer);
            _context.SaveChanges();
            return Ok(customer);
        }

        //[HttpPatch("{id}")]
        //public IActionResult Put(int id, Order_status status)
        //{
        //    var order = _context.Order.First(i => i.Id == id);
        //    order.Status = status;
        //    _context.SaveChanges();
        //    return Ok(order);
        //}

        [HttpPost]
        public IActionResult Post(string fullName, string username, string email, string phoneNumber)
        {
            var customer = new Customers
            {
                full_name = fullName,
                username = username,
                email = email,
                phone = phoneNumber,
                created_at = DateTime.Now,
                update_at = DateTime.Now
            };
            _context.customers.Add(customer);
            _context.SaveChanges();
            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = customer
            });
        }
        // GET: customers
        public async Task<IActionResult> Index()
        {
            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = View(await _context.customers.ToListAsync())
            });
        }
    
    }
}
