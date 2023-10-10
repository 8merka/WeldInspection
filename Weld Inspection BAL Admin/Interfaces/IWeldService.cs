using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weld_Inspection_DAL_Admin.Models;

namespace Weld_Inspection_BAL.Interfaces
{
    public interface IWeldService
    {
        IEnumerable<Welds> Get();
        void Create(Welds wels);
        Welds Update(int id, Welds welds);
        Welds Delete(int id);

    }
}
