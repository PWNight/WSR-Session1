using Microsoft.EntityFrameworkCore;
using WSR_SESSION1.Models;

namespace WSR_SESSION1
{
    public class WSRDbContext(DbContextOptions<WSRDbContext> options) : DbContext(options)
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<WSR_SESSION1.Models.Hospitalization> Hospitalization { get; set; } = default!;
    }
}