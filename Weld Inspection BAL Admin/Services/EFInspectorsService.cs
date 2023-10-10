using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weld_Inspection_DAL_Admin;
using Weld_Inspection_BAL_Admin.Interfaces;
using Weld_Inspection_DAL_Admin.Data;
using Weld_Inspection_DAL_Admin.Models;

namespace Weld_Inspection_BAL_Admin.Services
{
    public class EFInspectorsService : IInspectorsService
    {
        private readonly AppDbContext _context;

        public EFInspectorsService(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IEnumerable<Inspectors> Get() => _context.Inspectors;

        public void Create(Inspectors inspector)
        {
            _context.Inspectors.Add(inspector);
            _context.SaveChanges();
        }

        public Inspectors Update(int id, Inspectors inspector)
        {
            Inspectors existingInspector = _context.Inspectors.Find(id);
            if(existingInspector != null)
            {
                existingInspector.FirstName = inspector.FirstName;
                existingInspector.Lastname = inspector.Lastname;
                existingInspector.Phone = inspector.Phone;
                existingInspector.Email = inspector.Email;
                existingInspector.DateOfBirdth = inspector.DateOfBirdth;
                existingInspector.YearsOfWorking = inspector.YearsOfWorking;
                existingInspector.Rating = inspector.Rating;

                _context.SaveChanges();
                return existingInspector;
            }
            return null;
        }

        public Inspectors Delete(int id)
        {
            Inspectors deletedInspector = _context.Inspectors.Find(id);
            if(deletedInspector != null)
            {
                _context.Inspectors.Remove(deletedInspector);
                _context.SaveChanges();
                return deletedInspector;
            }
            return null;
        }

    }
}
