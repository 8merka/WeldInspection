using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weld_Inspection_DAL_Admin.Data;
using Weld_Inspection_DAL_Admin.Models;
using Weld_Inspection_BAL_Admin.Interfaces;

namespace Weld_Inspection_BAL_Admin.Services
{
    internal class EFDefectsService : IDefectsService
    {
        private readonly AppDbContext _context;

        public IEnumerable<Defects> Get() => _context.Defects;

        public void Create(Defects defects)
        {
            _context.Defects.Add(defects);
            _context.SaveChanges();
        }
        public Defects Update(int id, Defects defects)
        {
            Defects existingDefect = _context.Defects.Find(id);
            if(existingDefect != null)
            {
                existingDefect.ResultID = defects.ResultID;
                existingDefect.DefectType = defects.DefectType;
                existingDefect.LocationOfTheDefectInTheWeld = defects.LocationOfTheDefectInTheWeld;
                existingDefect.SizeAndCharacteristicsOfTheDefect = defects.SizeAndCharacteristicsOfTheDefect;
                existingDefect.SeverityLevelOfTheDefect = defects.SeverityLevelOfTheDefect;
                existingDefect.AdditionalComments = defects.AdditionalComments;

                _context.SaveChanges();

                return existingDefect;
            }
            return null;
        }
        public Defects Delete(int id)
        {
            Defects deletedDefect = _context.Defects.Find(id);
            if (deletedDefect != null)
            {
                _context.Defects.Remove(deletedDefect);
                _context.SaveChanges();

                return deletedDefect;
            }
            return null;
        }
    }
}
