namespace Weld_Inspection_DAL_Admin.Models
{
    public class InspectionEquipment
    {
        public int Id { get; set; }
        public string EquipmentName { get; set; }
        public string TechnicalSpecificationsOfTheEquipment { get; set; }
        public string EquipmentAvailability { get; set; }
        public string? CalibrationAndMaintenanceInformation { get; set; }

    }
}
