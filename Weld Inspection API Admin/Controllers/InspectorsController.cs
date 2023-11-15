using Microsoft.AspNetCore.Mvc;
using Weld_Inspection_BAL_Admin.Interfaces;
using Weld_Inspection_DAL_Admin.Data;
using Weld_Inspection_DAL_Admin.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Weld_Inspection_API_Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InspectorsController : ControllerBase
    {
        private readonly IInspectorsService _inspectorsService;

        public InspectorsController(IInspectorsService inspectorsService)
        {
            _inspectorsService = inspectorsService;
        }

        [HttpGet("GetAllInspectors")]
        public IEnumerable<Inspectors> Inspectors() => _inspectorsService.Get();

        [HttpPost("CreateInspector")]
        public IActionResult Create([FromBody] Inspectors inspectors)
        {
            if(Inspectors == null)
            {
                return BadRequest();
            }
            _inspectorsService.Create(inspectors);
            return Ok("Data was successfully added into table Inspectors");
        }

        [HttpPut("UpdateInspector/{id}")]
        public IActionResult Update(int id, [FromBody] Inspectors inspectors)
        {
            Inspectors updatedInspector = _inspectorsService.Update(id, inspectors);
            if(updatedInspector == null)
            {
                return NotFound();
            }
            return Ok($"Data with id {id} was successfully updated in table Inspectors");
        }

        [HttpDelete("DeleteInspector/{id}")]
        public IActionResult Delete(int id)
        {
            Console.WriteLine("В метод пришёл id: " + id);
            Inspectors deletedInspector = _inspectorsService.Delete(id);
            if (deletedInspector == null)
            {
                return NotFound();
            }
            return Ok($"Data with id {id} was successfully removed from table Inspectors");

        }
    }
}
