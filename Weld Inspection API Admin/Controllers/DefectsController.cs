using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weld_Inspection_BAL_Admin.Interfaces;
using Weld_Inspection_DAL_Admin.Models;

namespace Weld_Inspection_API_Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefectsController : ControllerBase
    {
        private readonly IDefectsService _defectsService;
        public DefectsController(IDefectsService defectsService)
        {
            _defectsService = defectsService;
        }

        [HttpGet("GetAllDefects")]
        public IEnumerable<Defects> Defect() => _defectsService.Get();
        [HttpPost("AddDefect")]
        public IActionResult Create([FromBody] Defects defects)
        {
            if(defects == null)
            {
                return BadRequest();
            }
            _defectsService.Create(defects);
            return Ok("Defect was successfully added into table Defects");
        }
        [HttpPut("UpdateDefect")]
        public IActionResult Update(int id, [FromBody] Defects defects)
        {
            Defects updatedDefect = _defectsService.Update(id, defects);
            if(updatedDefect == null)
            {
                return NotFound();
            }
            return Ok($"Defect with id {id} was successfully updated in table Defects");
        }
        [HttpDelete("DeleteDefect")]
        public IActionResult Delete(int id)
        {
            Defects deletedDefect = _defectsService.Delete(id);
            if (deletedDefect == null)
            {
                NotFound();
            }
            return Ok($"Defect with id {id} was successfully removed fron table Defects");
        }
    }
}
