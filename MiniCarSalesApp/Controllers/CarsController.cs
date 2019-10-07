using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniCarSalesApp.Helpers;

namespace MiniCarSalesApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {

        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return XMLSerializer.ReadVehiclesXML().Cars;
        }
    }
}
