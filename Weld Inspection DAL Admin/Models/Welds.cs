namespace Weld_Inspection_DAL_Admin.Models
{
    public class Welds
    {
        public int Id { get; set; }
        public int WelderId { get; set; }
        public DateOnly DateOfCreationOrModification { get; set; }
        public string WeldingType { get; set; }
        public string MaterialsUsedForWelding { get; set; }
        public string WeldGeometry { get; set; }
        public string? AdditionalWeldCharacteristics { get; set; }
    }
}
