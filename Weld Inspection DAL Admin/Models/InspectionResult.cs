namespace Weld_Inspection_DAL_Admin.Models
{
    public class InspectionResult
    {
        public int Id { get; set; }
        public int WeldId { get; set; }
        public int MethodId { get; set; }
        public int EmployeeId { get; set; }
        public int InspectionId { get; set;}
        public DateOnly DateOfInspection { get; set; }
        public bool isDefective { get; set; }
        public string? InspectorsNotesAndComments { get; set; }
    }
}
