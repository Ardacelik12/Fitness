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
    public class CampainController : ControllerBase
    {

        ICampainService _ICampainService;

        public CampainController(ICampainService ıCampainService)
        {
            _ICampainService = ıCampainService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _ICampainService.GetAll();
            if (result.Success)
            {

                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpGet("getbycategoryıd")]
        public IActionResult GetbyCategoryId(int id)
        {
            var result = _ICampainService.getByCategoryId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }
        [HttpPost("CampainPay")]
        public IActionResult CampainPay(Order order)
        {

            var result = _ICampainService.CampainPay(order);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
