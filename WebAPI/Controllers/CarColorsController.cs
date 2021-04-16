using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarColorsController : ControllerBase
    {
        ICarColorService _carColorService;

        public CarColorsController(ICarColorService carColorService)
        {
            _carColorService = carColorService;
        }

        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            var ressult = _carColorService.GettAll();
            if (ressult.Success)
            {
                return Ok(ressult);
            }

            return BadRequest(ressult);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _carColorService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(CarColor carColor)
        {
            var result = _carColorService.Add(carColor);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(CarColor carColor)
        {
            var result = _carColorService.Update(carColor);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(CarColor carColor)
        {
            var result = _carColorService.Delete(carColor);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

    }
}
