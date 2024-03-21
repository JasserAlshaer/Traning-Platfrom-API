using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Traning_Platfrom_Core.Dtos.JobSeeker;
using Traning_Platfrom_Core.Dtos.Login;
using Traning_Platfrom_Core.Dtos.Logout;
using Traning_Platfrom_Core.Dtos.OrganizationDTO;
using Traning_Platfrom_Core.Dtos.User;
using Traning_Platfrom_Core.IRepositaries;

namespace Traning_Platfrom_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthanticationController : ControllerBase
    {
        private readonly IAuthenticationService _service;
        public AuthanticationController(IAuthenticationService service)
        {
            _service = service;
        }
        [HttpPost]
        [Route("[action]")]
        public Task CreateJobSeekerAccount(CreateJobSeekerDTO dto)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [Route("[action]")]
        public Task CreateOrganizationAccount(CreateOrganizationDTO dto)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [Route("[action]")]
        public Task CreateUser(CreateUserDTO dto)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [Route("[action]")]
        public Task Login(LoginDTO dto)
        {
            throw new NotImplementedException();
        }
        [HttpPut]
        [Route("[action]")]
        public Task Logout(LogoutDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
