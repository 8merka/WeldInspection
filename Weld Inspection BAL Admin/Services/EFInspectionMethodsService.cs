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
    internal class EFInspectionMethodsService : IInspectionMethodsService
    {
        private readonly AppDbContext _context;
        public IEnumerable<InspectionMethods> Get() => _context.InspectionMethods;

        public void Create(InspectionMethods methods)
        {
            _context.InspectionMethods.Add(methods);
            _context.SaveChanges();
        }

        public InspectionMethods Update(int id, InspectionMethods methods)
        {
            InspectionMethods existingMethods = _context.InspectionMethods.Find(id);
            if (existingMethods != null)
            {
                existingMethods.EquipmentID = methods.EquipmentID;
                existingMethods.Name = methods.Name;
                existingMethods.Description = methods.Description;
                existingMethods.CostForExecution = methods.CostForExecution;
                existingMethods.AdditionalMethodCharacteristics = methods.AdditionalMethodCharacteristics;

                return existingMethods;
            }

            return null;
        }

        public InspectionMethods Delete(int id)
        {
            InspectionMethods deletedMethod = _context.InspectionMethods.Find(id);
            if(deletedMethod != null)
            {
                _context.InspectionMethods.Remove(deletedMethod);
                _context.SaveChanges();

                return deletedMethod;
            }
            return null;
        }
    }
}
