using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticeAPI.Entities;
using PracticeAPI.Interfaces;

namespace PracticeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FirstModelController : ControllerBase
    {
        private readonly IFirstModelRepository _firstModel;
        public FirstModelController(IFirstModelRepository firstModel)
        {
            _firstModel = firstModel;
        }

        [HttpGet]
        public async Task<ActionResult<List<FirstModel>>> GetAllHeroes()
        {
            return await _firstModel.GetAllAsync();
        }
    }
}