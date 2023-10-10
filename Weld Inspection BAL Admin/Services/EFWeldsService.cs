using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weld_Inspection_BAL.Interfaces;
using Weld_Inspection_DAL_Admin.Data;
using Weld_Inspection_DAL_Admin.Models;

namespace Weld_Inspection_BAL.Services
{
    internal class EFWeldsService: IWeldService
    {
        private readonly AppDbContext _context;
        public EFWeldsService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Welds> Get() => _context.Welds;
        
        public void Create(Welds welds)
        {
            _context.Welds.Add(welds);
            _context.SaveChanges();
        }

        public Welds Update(int id, Welds welds) 
        {
            Welds existingWeld = _context.Welds.Find(keyValues: id);
            if (existingWeld != null)
            {
                existingWeld.WelderId = welds.WelderId;
                existingWeld.DateOfCreationOrModification = welds.DateOfCreationOrModification;
                existingWeld.WeldingType = welds.WeldingType;
                existingWeld.MaterialsUsedForWelding = welds.MaterialsUsedForWelding;
                existingWeld.WeldGeometry = welds.WeldGeometry;
                existingWeld.AdditionalWeldCharacteristics = welds.AdditionalWeldCharacteristics;
                
                _context.SaveChanges();
                return existingWeld;
            }
            return null;
        }

        public Welds Delete(int id)
        {
            Welds weldsToDelete = _context.Welds.Find(keyValues: id);
            if (weldsToDelete != null)
            {
                _context.Welds.Remove(weldsToDelete);
                _context.SaveChanges();
                return weldsToDelete;
            }
            return null;
        }


    }
}
