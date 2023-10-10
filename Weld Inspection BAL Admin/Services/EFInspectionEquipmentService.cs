using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weld_Inspection_BAL_Admin.Interfaces;
using Weld_Inspection_DAL_Admin.Models;
using Weld_Inspection_DAL_Admin.Data;

namespace Weld_Inspection_BAL_Admin.Services
{
    internal class EFInspectionEquipmentService : IInspectionEquipmentService
    {
        private readonly AppDbContext _context;
        public IEnumerable<InspectionEquipment> Get() => _context.InspectionEquipment;

        public void Create(InspectionEquipment equipment)
        {
            _context.InspectionEquipment.Add(equipment);
            _context.SaveChanges();
        }

        public InspectionEquipment Update(int id, InspectionEquipment equipment)
        {
            InspectionEquipment existingEquipment = _context.InspectionEquipment.Find(id);
            if (existingEquipment != null)
            {
                existingEquipment.EquipmentName = equipment.EquipmentName;
                existingEquipment.TechnicalSpecificationsOfTheEquipment = equipment.TechnicalSpecificationsOfTheEquipment;
                existingEquipment.EquipmentAvailability = equipment.EquipmentAvailability;
                existingEquipment.CalibrationAndMaintenanceInformation = equipment.CalibrationAndMaintenanceInformation;

                return existingEquipment;
            }

            return null;
        }

        public InspectionEquipment Delete(int id)
        {
            InspectionEquipment deletedEquipment = _context.InspectionEquipment.Find(id);
            if (deletedEquipment != null)
            {
                _context.InspectionEquipment.Remove(deletedEquipment);
                _context.SaveChanges();

                return deletedEquipment;
            }
            return null;
        }
    }
}
