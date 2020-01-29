using ClinicManagement.Core;
using System.Linq;
using System.Web.Http;

namespace ClinicManagement.Controllers.Api
{
    public class UsersController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IHttpActionResult GetPatients()
        {
            return  Ok(_unitOfWork.Users.GetUsers().Where(user => user.IsActive.Value)); // should it return a viewModel?
        }
    }
}
