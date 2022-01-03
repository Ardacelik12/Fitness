using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        ICustomerService _ICustomerService;

        public CustomerController(ICustomerService ICustomerService)
        {
            _ICustomerService = ICustomerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _ICustomerService.GetAll();
            if (result.Success)
            {

                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpPost("deleteaccount")]
        public IActionResult deleteaccount(Customer customer)
        {

            var result = _ICustomerService.DeleteMyAccount(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("updatemyaccount")]
        public IActionResult UpdateMyAccount(Customer customer)
        {

            var result = _ICustomerService.UpdateMyAccount(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getcustomerinfo")]
        public IActionResult GetcustomerInfo(int id)
        {

            var result = _ICustomerService.getCustomerİnfo(id);
            if (result.Success)
            {

                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpPost("changepassword")]
        public IActionResult changepassword(Customer customer)
        {

            var result = _ICustomerService.ChangePassword(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("calculatebmı")]
        public IActionResult CBMI(Customer customer)
        {

            var result = _ICustomerService.bmıcalculate(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("calculatedailycalory")]
        public IActionResult DailyCalory(Customer customer)
        {

            var result = _ICustomerService.calculatecalory(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("cıkısyap")]
        public IActionResult cıkısyap(Customer customer)
        {
            var result = _ICustomerService.cıkısyap(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
