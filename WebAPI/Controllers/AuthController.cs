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
    public class AuthController : ControllerBase
    {
        ICustomerService _ICustomerService;

        public AuthController(ICustomerService ICustomerService)
        {
            _ICustomerService = ICustomerService;
        }
        [HttpPost("register")]
        public IActionResult ProgrammePay(Customer customer)
        {

            var result = _ICustomerService.Add(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("login")]
        public IActionResult login(Customer customer)
        {

            var result = _ICustomerService.login(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
