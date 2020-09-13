using System.Collections.Generic;

namespace BrainWorks.eHealth.Data
{
	public class Doctor
	{
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Mobile { get; set; }

		public string Email { get; set; }

		public string Specialization { get; set; }

		public string DaysAvailable { get; set; }

		public string Timings { get; set; }

		public string RoomName { get; set; }

		public IList<Appointment> Appointments { get; set; }
	}
}
