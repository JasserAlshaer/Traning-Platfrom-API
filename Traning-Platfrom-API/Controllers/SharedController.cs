using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Traning_Platfrom_Core.Dtos.JobField;
using Traning_Platfrom_Core.Dtos.JobOpportunity;
using Traning_Platfrom_Core.Dtos.JobSeeker;
using Traning_Platfrom_Core.Dtos.OrganizationDTO;
using Traning_Platfrom_Core.Dtos.StaticPage;
using Traning_Platfrom_Core.Dtos.Testimonal;
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
        public async Task<AboutUsDTO> GetAboutUsFacts()
        {
            return await _service.GetAboutUsDTOAsync();
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<List<JobFieldDTO>> GetJobFields()
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
        public async Task<List<JobOpportunityCardDTO>> GetJobOpportunityByJobFieldIdAsync(int Id)
        {
            return await _service.GetJobOpportunityByJobFieldIdAsync(Id);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<JobOpportunityDTO> GetJobOpportunityDetailsById(int Id)
        {
            return await _service.GetJobOpportunityDetailsByIdAsync(Id);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<List<OrganizationDTO>> GetOrganization()
        {
            return await _service.GetOrganizationAsync();
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<List<OrganizationCardDTO>> GetTopOrganization()
        {
            return await _service.GetTopOrganizationAsync();
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<List<Skill>> GetSkills()
        {
            return await _service.GetSkillsAsync();
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<List<TestimonalDTO>> GetTestimonials()
        {
            return await _service.GetTestimonialsAsync();
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<List<TopJobSeekerDTO>> GetTopJobSeekers()
        {
            return await _service.GetTopJobSeekersAsync();
        }
    }
}
