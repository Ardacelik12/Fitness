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
    public class CitiesController : ControllerBase
    {
        ICitiesService _ICitiesService;

        public CitiesController(ICitiesService ıCitiesService)
        {
            _ICitiesService= ıCitiesService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _ICitiesService.GetAll();
            if (result.Success)
            {

                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpGet("getbyıd")]
        public IActionResult GetbyId(int id)
        {
            var result = _ICitiesService.getById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);

        }
        [HttpGet("getnames")]
        public IActionResult GetNames(string s)
        {
            var result = _ICitiesService.Searchh(s);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);

        }

    }
}
