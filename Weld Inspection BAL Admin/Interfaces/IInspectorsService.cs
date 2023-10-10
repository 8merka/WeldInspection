using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weld_Inspection_DAL_Admin.Models;

namespace Weld_Inspection_BAL_Admin.Interfaces
{
    public interface IInspectorsService
    {
        IEnumerable<Inspectors> Get();
        void Create(Inspectors inspector);
        Inspectors Update(int id, Inspectors inspector);
        Inspectors Delete(int id);

    }
}
