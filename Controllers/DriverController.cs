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
    [Route("drivers")]
    public class DriverController : Controller
    {
        private readonly OnlineContext _context;

        public DriverController(OnlineContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var driver = _context.drivers;

            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = driver
            });
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var driver = _context.drivers.First(i => i.Id == id);

            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = driver
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var driver = _context.drivers.First(i => i.Id == id);

            _context.drivers.Remove(driver);
            _context.SaveChanges();
            return Ok(driver);
        }

        // [HttpPatch("{id}")]
        // public IActionResult Put(int id, Order_status status){
        //     var order = _context.Order.First(i => i.Id == id);
        //     order.Status = status;
        //     _context.SaveChanges();
        //     return Ok(order);
        // }

        [HttpPost]
        public IActionResult Post(string fullName, string phoneNumber)
        {
            var driver = new Drivers
            {
                full_name = fullName,
                phone_number = phoneNumber,
                created_at = DateTime.Now,
                update_at = DateTime.Now
            };
            _context.drivers.Add(driver);
            _context.SaveChanges();
            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = driver
            });
        }
    }
}
