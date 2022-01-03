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
    public class TrainerController : ControllerBase
    {

        ITrainerService _ITrainerService;

        public TrainerController(ITrainerService ıTrainerService)
        {
            _ITrainerService = ıTrainerService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _ITrainerService.GetAll();
            if (result.Success)
            {

                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpGet("getbyıd")]
        public IActionResult GetbyId(int id)
        {
            var result = _ITrainerService.getById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);

        }
        [HttpGet("gettrainerinfo")]
        public IActionResult GetTrainerInfo(int id)
        {

            var result = _ITrainerService.getTrainerİnfo(id);
            if (result.Success)
            {

                return Ok(result);

            }
            return BadRequest(result);
        }


    }
}
