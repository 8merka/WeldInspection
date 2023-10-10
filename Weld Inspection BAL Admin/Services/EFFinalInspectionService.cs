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
    internal class EFFinalInspectionService : IFinalInspectionService
    {
        private readonly AppDbContext _context;

        public EFFinalInspectionService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<FinalInspection> Get() => _context.FinalInspections;
        public void Create(FinalInspection finalInspection)
        {
            _context.FinalInspections.Add(finalInspection);
            _context.SaveChanges();
        }
        public FinalInspection Update(int id, FinalInspection finalInspection)
        {
            FinalInspection existingInspection = _context.FinalInspections.Find(keyValues: id);
            if(existingInspection != null)
            {
                existingInspection.ResultId = finalInspection.ResultId;
                existingInspection.DateOfFinalInspection = finalInspection.DateOfFinalInspection;
                existingInspection.InspectorCommentsAndObservations = finalInspection.InspectorCommentsAndObservations;

                return existingInspection; 
            }
            return null;
        }
        public FinalInspection Delete(int id)
        {
            FinalInspection deletedInspection = _context.FinalInspections.Find(keyValues: id);
            if(deletedInspection != null)
            {
                _context.FinalInspections.Remove(deletedInspection);
                _context.SaveChanges();

                return deletedInspection;
            }
            return null;
        }
    }
}
