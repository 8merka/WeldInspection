using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weld_Inspection_DAL_Admin.Models;

namespace Weld_Inspection_BAL_Admin.Interfaces
{
    internal interface IFinalInspectionService
    {
        IEnumerable<FinalInspection> Get();
        void Create(FinalInspection finalInspection);
        FinalInspection Update(int id, FinalInspection finalInspection);
        FinalInspection Delete(int id);
    }
}
