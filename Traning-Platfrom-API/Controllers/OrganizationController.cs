using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Traning_Platfrom_Core.Dtos.JobApplication;
using Traning_Platfrom_Core.Dtos.JobInterview;
using Traning_Platfrom_Core.Dtos.JobOpportunity;
using Traning_Platfrom_Core.Dtos.OrganizationDTO;
using Traning_Platfrom_Core.IRepositaries;

namespace Traning_Platfrom_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private readonly IOrganizationService _service;
        public OrganizationController(IOrganizationService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<OrganizationStatisticsDTO> GetOrganizationStatistics(int Id)
        {
            return await _service.GetOrganizationStatisticsAsync(Id);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<OrganizationDTO> GetOrganizationDTO(int Id)
        {
            return await _service.GetOrganizationDTOAsync(Id);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<List<JobOpportunityCardDTO>> GetJobOpportunityByOrganizationId(int Id)
        {
            return await _service.GetJobOpportunityByOrganizationIdAsync(Id);
        }
        [HttpGet]
        [Route("[action]")]
        public Task<List<JobInterviewDetailsDTO>> GetAllJobInterview(int Id)
        {
            return _service.GetAllJobInterviewAsync(Id);    
        }
        [HttpGet]
        [Route("[action]")]
        public Task<List<JobApplicationDetailsDTO>> GetJobApplicationByJobId(int Id)
        {
            return _service.GetJobApplicationAsync(Id);
        }
        [HttpGet]
        [Route("[action]")]
        public Task<List<JobApplicationDTO>> GetTopApplicant()
        {
            return _service.GetTopApplicantAsync();
        }
        [HttpPost]
        [Route("[action]")]
        public Task CompleteOrganizationProfile(CreateOrganizationDTO dto)
        {
            return _service.CompleteOrganizationProfileAsync(dto);
        }
        [HttpPost]
        [Route("[action]")]
        public Task CreateJobInterview(CreateJobInterviewDTO dto)
        {
            return _service.CreateJobInterviewAsync(dto);
        }
        [HttpPost]
        [Route("[action]")]
        public Task CreateJobOpportunity(JobOpportunityCardDTO dto)
        {
            return _service.CreateJobOpportunityAsync(dto);
        }
        [HttpPut]
        [Route("[action]")]
        public Task UpdateJobInterview(CreateJobInterviewDTO dto)
        {
            return _service.UpdateJobInterviewAsync(dto);
        }
        [HttpPut]
        [Route("[action]")]
        public Task UpdateJobOpportunity(JobOpportunityCardDTO dto)
        {
            return _service.UpdateJobOpportunityAsync(dto);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task UpdateOrganizationSocialInfo(OrganizationSocialMediaDTO dto)
        {
            await _service.UpdateOrganizationSocialInfoAsync(dto);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task UpdateOrganizationContactInfo(OrganizationContactDTO dto)
        {
            await _service.UpdateOrganizationContactInfoAsync(dto);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task UpdateOrganizationProfileImage(OrganizationProfileImageDTO dto)
        {
            await _service.UpdateOrganizationProfileImageAsync(dto);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task UpdateOrganizationMainInfo(OrganizationMainInfoDTO dto)
        {
            await _service.UpdateOrganizationMainInfoAsync(dto);
        }
        [HttpDelete]
        [Route("[action]")]
        public Task DeleteJobInterview(int Id)
        {
            return _service.DeleteJobInterviewAsync(Id);
        }
        [HttpDelete]
        [Route("[action]")]
        public Task DeleteJobOpportunity(int Id)
        {
            return _service.DeleteJobOpportunityAsync(Id);
        }
    }
}
