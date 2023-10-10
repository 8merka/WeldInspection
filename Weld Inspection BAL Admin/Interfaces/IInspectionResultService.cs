using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weld_Inspection_DAL_Admin.Models;


namespace Weld_Inspection_BAL_Admin.Interfaces
{
    internal interface IInspectionResultService
    {
        IEnumerable<InspectionResult> Get();
        void Create(InspectionResult result);
        InspectionResult Update(int id, InspectionResult result);
        InspectionResult Delete(int id);
    }
}
