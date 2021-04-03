using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            {
                //Thread.Sleep(1000); // 10 sn. gecikme

                var result = _categoryService.GetAll();
                //swagger
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);

            }

        }
    }
}
