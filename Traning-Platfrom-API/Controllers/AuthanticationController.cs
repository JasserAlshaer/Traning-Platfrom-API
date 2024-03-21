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
        public async Task CreateJobSeekerAccount(CreateJobSeekerDTO dto)
        {
             await _service.CreateJobSeekerAccountAsync(dto);
        }
        [HttpPost]
        [Route("[action]")]
        public async Task CreateOrganizationAccount(CreateOrganizationDTO dto)
        {
             await _service.CreateOrganizationAccountAsync(dto);
        }
        [HttpPost]
        [Route("[action]")]
        public async Task CreateUser(CreateUserDTO dto)
        {
             await _service.CreateUserAsync(dto);
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<string> Login(LoginDTO dto)
        {
            return await _service.LoginAsync(dto);
        }
    }
}
