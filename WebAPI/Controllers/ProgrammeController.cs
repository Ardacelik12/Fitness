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
    public class ProgrammeController : ControllerBase
    {
        IProgrammeService _IProgrammeService;

        public ProgrammeController(IProgrammeService ıProgrammeService)
        {
            _IProgrammeService = ıProgrammeService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _IProgrammeService.GetAll();
            if (result.Success)
            {

                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpGet("getbycategoryid")]
        public IActionResult GetbyCategoryId(int id)
        {
            var result = _IProgrammeService.getByCategoryId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }
        [HttpPost("ProgrammePay")]
        public IActionResult ProgrammePay(Order order)
        {

            var result = _IProgrammeService.ProgrammePay(order);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getprogrammesbycustomerıd")]
        public IActionResult GetProgrammesByCustomerId(int id)
        {

            var result = _IProgrammeService.GetProgrammesByCustomerId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("ProgrammeCancelled")]
        public IActionResult ProgrammeCancelled(Order order)
        {

            var result = _IProgrammeService.ProgrammeDelete(order);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
    }
}
