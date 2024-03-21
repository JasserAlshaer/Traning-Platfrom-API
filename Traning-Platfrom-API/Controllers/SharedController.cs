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
        public async Task<List<JobField>> GetJobFields()
        {
            return await _service.GetJobFieldsAsync();    
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<List<JobOpportunityCardDTO>> GetJobOpportunity()
        {
            return await _service.GetJobOpportunityAsync();
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<List<OrganizationDTO>> GetOrganization()
        {
            return await _service.GetOrganizationAsync();    
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<List<Skill>> GetSkills()
        {
            return await _service.GetSkillsAsync();    
        }
    }
}
