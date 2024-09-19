using System;
using System.ComponentModel.DataAnnotations;
namespace WSR_SESSION1.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Fio is required.")]
        public string Fio { get; set; }

        [Required(ErrorMessage = "PassportData is required.")]
        public string PassportData { get; set; }

        [Required(ErrorMessage = "WorkPlace is required.")]
        public string WorkPlace { get; set; }

        [Required(ErrorMessage = "PolicyNumber is required.")]
        public string PolicyNumber { get; set; }

        [Required(ErrorMessage = "PolicyExpire is required.")]
        public DateTime PolicyExpire { get; set; }

        [Required(ErrorMessage = "PolicyCompany is required.")]
        public string PolicyCompany { get; set; }

        public int MedicalCardId { get; set; }
        public string PhotoPath { get; set; }
    }
}
