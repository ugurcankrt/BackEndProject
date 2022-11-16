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
    public class BoatsController : ControllerBase
    {
        private readonly IBoatService _boatService;

        public BoatsController(IBoatService boatService)
        {
            _boatService = boatService;
        }

        [HttpGet("getBoatByColorId")]
        public IActionResult GetBoatByColorId(int colorId)
        {
            var result = _boatService.GetBoatByColorId(colorId);

            return StatusCode(result.Success ? 200 : 400, result);
        }
    }
}
