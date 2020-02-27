using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TryoutFebruari.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OnlineOrderController : ControllerBase
    {


        private readonly ILogger<OnlineOrderController> _logger;

        public OnlineOrderController(ILogger<OnlineOrderController> logger)
        {
            _logger = logger;
        }

    }
}
