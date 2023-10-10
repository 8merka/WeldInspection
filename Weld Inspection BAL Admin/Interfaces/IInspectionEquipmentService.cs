using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weld_Inspection_DAL_Admin.Models;


namespace Weld_Inspection_BAL_Admin.Interfaces
{
    internal interface IInspectionEquipmentService
    {
        IEnumerable<InspectionEquipment> Get();
        void Create(InspectionEquipment equip);
        InspectionEquipment Update(int id, InspectionEquipment equip);
        InspectionEquipment Delete(int id);
    }
}
