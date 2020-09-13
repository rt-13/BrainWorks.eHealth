using System.Collections.Generic;

namespace BrainWorks.eHealth.Data
{
	public class Patient
	{
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Mobile { get; set; }

		public string Email { get; set; }

		public IList<Appointment> Appointments { get; set; }
	}
}
