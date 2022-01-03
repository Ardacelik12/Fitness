using Business.Abstract;
using Entities.DTOs;
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
    public class ContactInfoController : ControllerBase
    {
        IContactInfoService _IContactInfoService;

        public ContactInfoController(IContactInfoService ıContactInfoService)
        {
            _IContactInfoService = ıContactInfoService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _IContactInfoService.GetAll();
            if (result.Success)
            {

                return Ok(result);

            }
            return BadRequest(result);

        }
        [HttpPost("contactus")]
        public IActionResult ContactUs(ContactDto contactdto)
        {
            var result = _IContactInfoService.ContactUs(contactdto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
