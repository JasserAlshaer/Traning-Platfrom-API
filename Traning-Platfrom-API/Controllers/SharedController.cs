using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Traning_Platfrom_Core.Dtos.JobOpportunity;
using Traning_Platfrom_Core.Dtos.OrganizationDTO;
using Traning_Platfrom_Core.Entity.Lookups;
using Traning_Platfrom_Core.IRepositaries;

namespace Traning_Platfrom_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharedController : ControllerBase
    {
        private readonly ISharedService _service;
        public SharedController(ISharedService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("[action]")]
        public Task<List<JobField>> GetJobFields()
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        [Route("[action]")]
        public Task<List<JobOpportunityDTO>> GetJobOpportunity()
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        [Route("[action]")]
        public Task<List<OrganizationDTO>> GetOrganization()
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        [Route("[action]")]
        public Task<List<Skill>> GetSkills()
        {
            throw new NotImplementedException();
        }
    }
}
