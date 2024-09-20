namespace WSR_SESSION1.Models
{
    public class Patient
    {
        public int Id { get; set; }

        public required string Fio { get; set; }

        public required string PassportData { get; set; }

        public required string WorkPlace { get; set; }

        public required string PolicyNumber { get; set; }

        public DateTime PolicyExpire { get; set; }

        public required string PolicyCompany { get; set; }

        public int MedicalCardId { get; set; }
        public required string PhotoPath { get; set; }
    }
}
