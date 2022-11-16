using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusesController : ControllerBase
    {
        private readonly IBusService _busService;

        public BusesController(IBusService busService)
        {
            _busService = busService;
        }

        [HttpGet("getBusByColorId")]
        public IActionResult GetBusByColorId(int colorId)
        {
            var result = _busService.GetBusByColorId(colorId);

            return StatusCode(result.Success ? 200 : 400, result);
        }
    }
}
