using System;

namespace BrainWorks.eHealth.Data
{
	public class Appointment
	{
		public int Id { get; set; } //PK 

		public int PatientId { get; set; } //FK to Patient

		public Patient Patient { get; set; } //FK

		public int DoctorId { get; set; } //FK to Doctor

		public Doctor Doctor { get; set; }

		public DateTime AppointmentDate { get; set; }

		public string Diagnosis { get; set; }

		public string Treatment { get; set; }

		public string Prescription { get; set; }

		public decimal AmountPayable { get; set; }

		public string Status { get; set; }
	}
}
