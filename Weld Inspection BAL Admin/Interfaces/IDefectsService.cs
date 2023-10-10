using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weld_Inspection_DAL_Admin.Models;

namespace Weld_Inspection_BAL_Admin.Interfaces
{
    public interface IDefectsService
    {
        IEnumerable<Defects> Get();
        void Create(Defects defects);
        Defects Update(int id, Defects defects);
        Defects Delete(int id);
    }
}
