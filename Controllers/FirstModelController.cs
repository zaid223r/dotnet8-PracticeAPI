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

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] FirstModel firstModel)
        {
            var createdModel = await _firstModel.CreateAsync(firstModel);
            return StatusCode(201,createdModel);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id,[FromBody] FirstModel firstModel)
        {
            var updatedModel = await _firstModel.UpdateAsync(id,firstModel);

            if(updatedModel == null)
            {
                return NotFound();
            }

            return Ok(updatedModel);            
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var deletedModel = await _firstModel.DeleteAsync(id);

            if(deletedModel == null)
            {
                return NotFound();
            }

            return NoContent();
        }

    
    }
}