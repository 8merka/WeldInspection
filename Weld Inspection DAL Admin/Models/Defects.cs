namespace Weld_Inspection_DAL_Admin.Models
{
    public class Defects
    {
        public int Id { get; set; }
        public int ResultID { get; set; }
        public string DefectType { get; set; }
        public string LocationOfTheDefectInTheWeld { get; set; }
        public string SizeAndCharacteristicsOfTheDefect { get; set; }
        public string SeverityLevelOfTheDefect { get; set; }
        public string? AdditionalComments { get; set; }

        
    }
}
