using Business.Abstract;
using Entities.Dto;
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
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getCarByColorId")]
        public IActionResult GetCarByColorId(int colorId)
        {
            var result = _carService.GetCarByColorId(colorId);

            return StatusCode(result.Success ? 200 : 400, result);
        }

        [HttpPost("deleteCarById")]
        public IActionResult Delete(DeleteForCarDto dto)
        {
            var result = _carService.DeleteCar(dto);

            return StatusCode(result.Success ? 200 : 400, result);
        }

        [HttpPost("updateHeadlightStatus")]
        public IActionResult UpdateHeadlightStatus(UpdateHeadlightDto dto)
        {
            var result = _carService.UpdateHeadlight(dto);

            return StatusCode(result.Success ? 200 : 400, result);
        }
    }
}
