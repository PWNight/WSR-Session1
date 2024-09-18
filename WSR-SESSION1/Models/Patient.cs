namespace WSR_SESSION1.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Fio { get; set; }
        public string PassportData { get; set; }
        public string WorkPlace { get; set; }
        public string PolicyNumber { get; set; }
        public DateOnly PolicyExpire { get; set; }
        public string PolicyCompany { get; set; }
        public int MedicalCardId { get; set; }
        public string PhotoPath { get; set; }
    }
}
