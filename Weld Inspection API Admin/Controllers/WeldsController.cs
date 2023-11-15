using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weld_Inspection_BAL.Interfaces;
using Weld_Inspection_DAL_Admin.Models;

namespace Weld_Inspection_API_Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeldsController : ControllerBase
    {
        private readonly IWeldService _weldService;

        public WeldsController(IWeldService weldService)
        {
            _weldService = weldService;
        }

        [HttpGet("GetAllWelds")]
        public IEnumerable<Welds> Welds() => _weldService.Get();

        [HttpPost("AddWeld")]
        public IActionResult Create([FromBody] Welds weld)
        {
            if(weld == null)
            {
                return BadRequest();
            }
            _weldService.Create(weld);
            return Ok("Weld was successfully added into table Welds");
        }

        [HttpPut("UpdateWeld")]
        public IActionResult Update(int id, [FromBody] Welds weld)
        {
            Welds updatedWeld = _weldService.Update(id, weld);
            if (updatedWeld == null)
            {
                return NotFound();
            }
            return Ok($"Weld with id {id} was successfully updated into table Welds");
        }

        [HttpDelete("DeleteWeld")]
        public IActionResult Delete(int id)
        {
            Welds weld = _weldService.Delete(id);
            if (weld == null)
            {
                return NotFound();
            }
            return Ok($"Weld with id {id} was successfully removed from table Welds");
        }


    }
}
