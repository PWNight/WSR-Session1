namespace WSR_SESSION1.Models
{
    public class Hospitalization
    {
        public required int Id { get; set; }
        public required int PatientId { get; set; }
        public required string Code { get; set; }
        public required DateTime Date { get; set; }
        public required string Department { get; set; }
        public required string Conditions { get; set; }
        public required string AdditionalInfo { get; set; }
        public required bool IsCancelled { get; set; }
        public required string CancellationReason { get; set; }
    }
}
