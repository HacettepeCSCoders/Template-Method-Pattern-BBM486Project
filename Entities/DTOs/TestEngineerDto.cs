namespace Entities.DTOs
{
    public class TestEngineerDto:IDto
    {
        public int Id { get; set; }
        public int ManagerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ManagerName { get; set; }
        // public string Address { get; set; }
        // public long Phone { get; set; }
        // public string EmailAddress { get; set; }
        // public DateTime StartDate { get; set; }
        // public DateTime EndDate { get; set; }
        // public string WorkSituation { get; set; }
        public decimal Wage { get; set; }
    }
}