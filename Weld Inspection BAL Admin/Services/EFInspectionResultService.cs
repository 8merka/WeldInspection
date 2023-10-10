using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weld_Inspection_BAL_Admin.Interfaces;
using Weld_Inspection_DAL_Admin.Data;
using Weld_Inspection_DAL_Admin.Models;


namespace Weld_Inspection_BAL_Admin.Services
{
    internal class EFInspectionResultService : IInspectionResultService
    {
        private readonly AppDbContext _context;

        public IEnumerable<InspectionResult> Get() => _context.InspectionResult;
        public void Create(InspectionResult result) 
        { 
            _context.InspectionResult.Add(result);
            _context.SaveChanges();
        }
        public InspectionResult Update(int id, InspectionResult result)
        {
            InspectionResult existingResult = _context.InspectionResult.Find(id);
            if (existingResult != null)
            {
                existingResult.WeldId = result.WeldId;
                existingResult.MethodId = result.MethodId;
                existingResult.EmployeeId = result.EmployeeId;
                existingResult.InspectionId = result.InspectionId;
                existingResult.DateOfInspection = result.DateOfInspection;
                existingResult.isDefective = result.isDefective;
                existingResult.InspectorsNotesAndComments = result.InspectorsNotesAndComments;

                _context.SaveChanges();
                return existingResult;

            }
            return null;
        }

        public InspectionResult Delete(int id)
        {
            InspectionResult deletedReult = _context.InspectionResult.Find(id);
            if (deletedReult != null)
            {
                _context.InspectionResult.Remove(deletedReult);
                _context.SaveChanges();

                return deletedReult;
            }
            return null;
        }
    }
}
