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
    public class BlogPostController : ControllerBase
    {
        IBlogPostService _IBlogPostService;

        public BlogPostController(IBlogPostService ıBlogPostService)
        {
            _IBlogPostService = ıBlogPostService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {

            var result = _IBlogPostService.GetAll();
            if (result.Success)
            {

                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpGet("getbyıd")]
        public IActionResult GetbyId(int id)
        {
            var result = _IBlogPostService.getById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);

        }
    }
}
