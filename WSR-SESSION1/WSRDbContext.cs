using Microsoft.EntityFrameworkCore;
using WSR_SESSION1.Models;

namespace WSR_SESSION1
{
    public class WSRDbContext(DbSet<Patient> patients, DbSet<Hospitalization> hospitalizations) : DbContext
    {
        public DbSet<Patient> Patients { get; set; } = patients;
        public DbSet<Hospitalization> Hospitalizations { get; set; } = hospitalizations;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Настройка моделей, если необходимо
        }
    }
}