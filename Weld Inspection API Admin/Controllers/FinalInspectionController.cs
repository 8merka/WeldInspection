using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weld_Inspection_BAL_Admin.Interfaces;
using Weld_Inspection_DAL_Admin.Models;

namespace Weld_Inspection_API_Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinalInspectionController : ControllerBase
    {
        private readonly IFinalInspectionService _finalInspectionService;
        public FinalInspectionController(IFinalInspectionService finalInspectionService)
        {
            _finalInspectionService = finalInspectionService;
        }
        [HttpGet("GetAllFinalInspectors")]
        public IEnumerable<FinalInspection> FinalInspections() => _finalInspectionService.Get();
        [HttpPost("CreateFinalInspector")]
        public IActionResult Create([FromBody] FinalInspection finalInspection)
        {
            if(finalInspection == null)
            {
                return BadRequest();
            }
            _finalInspectionService.Create(finalInspection);
            return Ok("Final inspector was successfully added into table FinalInspection");
        }
        [HttpPut("UpdateFinalInspector")]
        public IActionResult Update(int id, [FromBody] FinalInspection finalInspection)
        {
            FinalInspection updatedFinalInspector = _finalInspectionService.Update(id, finalInspection);
            if (updatedFinalInspector == null)
            {
                return NotFound();
            }
            return Ok($"Final inspector with id {id} was successfully updated in table FinalInspectors");
        }
        [HttpDelete("DeleteFinalInspector")]
        public IActionResult Delete(int id)
        {
            FinalInspection deletedFinalInspector = _finalInspectionService.Delete(id);
            if (deletedFinalInspector == null)
            {
                return NotFound();
            }
            return Ok($"Final inspector with id {id} was successfully removed from table FinalInspectors");
        }
    }
}
