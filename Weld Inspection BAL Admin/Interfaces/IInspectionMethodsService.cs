using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weld_Inspection_DAL_Admin.Models;


namespace Weld_Inspection_BAL_Admin.Interfaces
{
    internal interface IInspectionMethodsService
    {
        IEnumerable<InspectionMethods> Get();
        void Create(InspectionMethods method);
        InspectionMethods Update(int id, InspectionMethods method);
        InspectionMethods Delete(int id);
    }
}
