namespace Weld_Inspection_DAL_Admin.Models
{
    public class InspectionMethods
    {
        public int Id { get; set; }
        public int EquipmentID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CostForExecution { get; set; }
        public string? AdditionalMethodCharacteristics { get; set; }

    }
}
