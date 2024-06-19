using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticeAPI.Entities;

namespace PracticeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FirstModelController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<FirstModel>>> GetAllHeroes()
        {
            var heroes = new List<FirstModel> 
            {
                new FirstModel
                {
                    Id = 1,
                    Name = "Batman"
                }
            };

            return Ok(heroes);
        }
    }
}