using Microsoft.EntityFrameworkCore;
using WSR_SESSION1.Models;

namespace WSR_SESSION1
{
    public class WSRDbContext : DbContext
    {
        public WSRDbContext(DbContextOptions<WSRDbContext> options) : base(options)
        {
        }
        public DbSet<Patient> Patients { get; set; }
    }
}