namespace Weld_Inspection_DAL_Admin.Models
{
    public class Inspectors
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateOnly DateOfBirdth { get; set; }
        public int YearsOfWorking { get; set; }
        public decimal Rating { get; set; }

    }
}
