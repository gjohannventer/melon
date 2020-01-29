using System;

namespace ClinicManagement.Core.Dto
{
    public class AppointmentCreateDto
    {
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public string Detail { get; set; }
        public bool Status { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
    }
}
