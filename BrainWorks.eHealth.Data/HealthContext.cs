using Microsoft.EntityFrameworkCore;

namespace BrainWorks.eHealth.Data
{
	public class HealthContext : DbContext
	{
		public DbSet<Patient> Patients { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Appointment> Appointments { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string connectionString = "Data Source=RT-Adeptus;Initial Catalog=e-Health;Integrated Security=True";
			optionsBuilder.UseSqlServer(connectionString);
		}
	}
}
