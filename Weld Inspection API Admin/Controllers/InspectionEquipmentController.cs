using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weld_Inspection_BAL_Admin.Interfaces;
using Weld_Inspection_DAL_Admin.Models;

namespace Weld_Inspection_API_Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InspectionEquipmentController : ControllerBase
    {
        private readonly IInspectionEquipmentService _inspectionEquipment;
        public InspectionEquipmentController(IInspectionEquipmentService inspectionEquipment)
        {
            _inspectionEquipment = inspectionEquipment;
        }
        [HttpGet("GetAllEquipment")]
        public IEnumerable<InspectionEquipment> GetInspectionEquipment() => _inspectionEquipment.Get();
        [HttpPost("CreateEquipment")]
        public IActionResult Create([FromBody] InspectionEquipment inspectionEquipment)
        {
            if (inspectionEquipment == null)
            {
                return BadRequest();
            }
            _inspectionEquipment.Create(inspectionEquipment);
            return Ok();
        }
        [HttpPut("UpdateEquipment")]
        public IActionResult Update(int id, [FromBody] InspectionEquipment inspectionEquipment)
        {
            InspectionEquipment updatedEquopment = _inspectionEquipment.Update(id, inspectionEquipment);
            if(updatedEquopment == null)
            {
                return NotFound();
            }
            return Ok($"Data with id {id} was successfully updated in table Inspection equipment");
        }
        [HttpDelete("DeleteEquipment")]
        public IActionResult Delete(int id)
        {
            InspectionEquipment deletedEquipment = _inspectionEquipment.Delete(id);
            if (deletedEquipment == null)
            {
                NotFound();
            }
            return Ok($"Data with id {id} was successfully removed from table Inspection equipment");
        }
    }
}
