﻿using BrainWorks.eHealth.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BrainWorks.eHealth.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			HealthContext context = new HealthContext();
			//AddPatients(context);
			//AddDoctors(context);

			//List<Doctor> doctorList = context.Doctors.ToList();
			//foreach (var doctor in doctorList)
			//{
			//	UpdateDoctorDetails(doctor, RandomSpecialization(), "Monday to Friday", "10:00 AM to 5:00 PM", "Room A");
			//}
			//context.SaveChanges();

			//Doctor doctor = context.Doctors.FirstOrDefault(x => x.FirstName == "Doctor 3");
			//Patient patient = context.Patients.FirstOrDefault(x => x.FirstName == "Patient 1");
			//DateTime appointmentDate = Convert.ToDateTime("15/09/2020");
			//AddAppointment(context, doctor, patient, appointmentDate);

			//appointmentDate = Convert.ToDateTime("16/09/2020");
			//AddAppointment(context, doctor, patient, appointmentDate);

			//appointmentDate = Convert.ToDateTime("17/09/2020");
			//AddAppointment(context, doctor, patient, appointmentDate);

			//appointmentDate = Convert.ToDateTime("18/09/2020");
			//AddAppointment(context, doctor, patient, appointmentDate);

			//List<Patient> patients = context.Patients.Include;

			var patients = context.Patients.Include(x => x.Appointments).ToList();


		}

		private static void AddPatients(HealthContext context)
		{
			context.Patients.Add(new Patient()
			{
				FirstName = "Patient 1",
				LastName = "Patient 1",
				Email = "p1@gmail.com",
				Mobile = "300001"
			});

			context.Patients.Add(new Patient()
			{
				FirstName = "Patient 2",
				LastName = "Patient 2",
				Email = "p2@gmail.com",
				Mobile = "300002"
			});

			context.Patients.Add(new Patient()
			{
				FirstName = "Patient 3",
				LastName = "Patient 3",
				Email = "p3@gmail.com",
				Mobile = "300003"
			});

			context.Patients.Add(new Patient()
			{
				FirstName = "Patient 4",
				LastName = "Patient 4",
				Email = "p4@gmail.com",
				Mobile = "300004"
			});

			context.SaveChanges();
		}

		private static void AddDoctors(HealthContext context)
		{
			context.Doctors.Add(new Doctor()
			{
				FirstName = "Doctor 1",
				LastName = "Doctor 1",
				Email = "d1@gmail.com",
				Mobile = "500001"
			});

			context.Doctors.Add(new Doctor()
			{
				FirstName = "Doctor 2",
				LastName = "Doctor 2",
				Email = "d2@gmail.com",
				Mobile = "500002"
			});

			context.Doctors.Add(new Doctor()
			{
				FirstName = "Doctor 3",
				LastName = "Doctor 3",
				Email = "d3@gmail.com",
				Mobile = "500003"
			});

			context.Doctors.Add(new Doctor()
			{
				FirstName = "Doctor 4",
				LastName = "Doctor 4",
				Email = "d4@gmail.com",
				Mobile = "500004"
			});

			context.SaveChanges();
		}

		private static void UpdateDoctorDetails(Doctor doctor, string specialization, string daysAvailable, string timings, string roomName)
		{
			doctor.Specialization = specialization;
			doctor.DaysAvailable = daysAvailable;
			doctor.Timings = timings;
			doctor.RoomName = roomName;
		}

		private static void AddAppointment(HealthContext context, Doctor doctor, Patient patient, DateTime appointmentDate)
		{
			Appointment appointment = new Appointment();
			appointment.DoctorId = doctor.Id;
			appointment.PatientId = patient.Id;
			appointment.AppointmentDate = appointmentDate;
			appointment.Status = "Confirmed";

			context.Appointments.Add(appointment);
			context.SaveChanges();
		}

		private static string RandomSpecialization()
		{
			string[] specialization = new string[] { "Cardiologist", "Nephologist", "Oncologist" };
			Random random = new Random(0);
			int number = random.Next(2);
			return specialization[number];
		}
	}
}
