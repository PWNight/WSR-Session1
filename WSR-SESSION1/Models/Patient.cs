namespace WSR_SESSION1.Models
{
    public class Patient
    {
        public required int Id { get; set; }
        public required string Fio { get; set; }
        public required string PassportData { get; set; }
        public required string WorkPlace { get; set; }
        public required string PolicyNumber { get; set; }
        public required DateTime PolicyExpire { get; set; }
        public required string PoliceCompany { get; set; }
        public required string MedicalCardId { get; set; }
        public required string PhotoPath { get; set; }
    }
}
