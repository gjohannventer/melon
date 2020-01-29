using ClinicManagement.Core;
using ClinicManagement.Core.Dto;
using ClinicManagement.Core.Models;
using System.Web.Http;

namespace ClinicManagement.Controllers.Api
{
    public class AppointmentController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        public AppointmentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public IHttpActionResult CreateAppointment(AppointmentCreateDto appointCreateDto)
        {
            var appointment = new Appointment
            {
                Detail = appointCreateDto.Detail,
                DoctorId = appointCreateDto.DoctorId,
                PatientId = appointCreateDto.PatientId,
                StartDateTime = appointCreateDto.StartDateTime,
                Status = appointCreateDto.Status
            };

            //Check if the slot is available
            if (_unitOfWork.Appointments.ValidateAppointment(appointment.StartDateTime, appointCreateDto.DoctorId))
                return NotFound();// Should return a better error with a message but it takes a bit of time to implement

            _unitOfWork.Appointments.Add(appointment);
            _unitOfWork.Complete();

            return Ok();
        }
    }
}