using Business.Abstract;
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
    public class OrderController : ControllerBase
    {
        IOrderService _IOrderService;

        public OrderController(IOrderService ıProgrammeService)
        {
            _IOrderService = ıProgrammeService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _IOrderService.getall();
            if (result.Success)
            {

                return Ok(result);

            }
            return BadRequest(result);
        }
    }
}
