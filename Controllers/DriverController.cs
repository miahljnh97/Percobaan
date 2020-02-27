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

        [HttpPut("{id}")]
        public IActionResult Put(int id, Drivers driput)
        {
            var dri = _context.drivers.First(i => i.Id == id);

            dri.full_name = driput.full_name;
            dri.phone_number = driput.phone_number;
            dri.created_at = dri.created_at;
            dri.update_at = DateTime.Now;

            _context.drivers.Update(dri);
            _context.SaveChanges();
            return Ok(dri);
        }

        [HttpPost]
        public IActionResult Post(Drivers driver)
        {
            driver = new Drivers
            {
                full_name = driver.full_name,
                phone_number = driver.phone_number,
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
