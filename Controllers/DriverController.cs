using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TryoutFebruari.Controllers
{
    [ApiController]
    [Route("[driver]")]
    public class DriverController : ControllerBase
    {


        private readonly ILogger<DriverController> _logger;

        public DriverController(ILogger<DriverController> logger)
        {
            _logger = logger;
        }
    }
}
