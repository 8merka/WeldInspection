namespace Weld_Inspection_DAL_Admin.Models
{
    public class FinalInspection
    {

        public int Id { get; set; }
        public int ResultId { get; set; }
        public DateOnly DateOfFinalInspection { get; set; }
        public string? InspectorCommentsAndObservations { get; set; }
    }
}
