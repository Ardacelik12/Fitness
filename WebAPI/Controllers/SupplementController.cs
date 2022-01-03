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
    public class SupplementController : ControllerBase
    {
        ISupplementService _ISupplementService;

        public SupplementController(ISupplementService ıSupplementService)
        {
            _ISupplementService = ıSupplementService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _ISupplementService.GetAll();
            if (result.Success)
            {

                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPost("SupplementPay")]
        public IActionResult SupplementPay(Order order)
        {

            var result = _ISupplementService.SupplementPay(order);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
