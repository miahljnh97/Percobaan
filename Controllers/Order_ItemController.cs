using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TryoutFebruari.Controllers
{
    [ApiController]
    [Route("[item]")]
    public class OrderItemController : ControllerBase
    {


        private readonly ILogger<OrderItemController> _logger;

        public OrderItemController(ILogger<OrderItemController> logger)
        {
            _logger = logger;
        }

    }
}
