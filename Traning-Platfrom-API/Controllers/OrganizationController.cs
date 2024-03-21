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
        public Task<List<JobInterviewDTO>> GetAllJobInterview(int Id)
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        [Route("[action]")]
        public Task<List<JobApplicationDTO>> GetJobApplication()
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        [Route("[action]")]
        public Task<List<JobApplicationDTO>> GetTopApplicant()
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [Route("[action]")]
        public Task CompleteOrganizationProfile(CreateOrganizationDTO dto)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [Route("[action]")]
        public Task CreateJobInterview(CreateJobInterviewDTO dto)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [Route("[action]")]
        public Task CreateJobOpportunity(CreateJobOpportunityDTO dto)
        {
            throw new NotImplementedException();
        }
        [HttpPut]
        [Route("[action]")]
        public Task UpdateJobInterview(CreateJobInterviewDTO dto)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [Route("[action]")]
        public Task UpdateJobOpportunity(CreateJobOpportunityDTO dto)
        {
            throw new NotImplementedException();
        }
        [HttpDelete]
        [Route("[action]")]
        public Task DeleteJobInterview(int Id)
        {
            throw new NotImplementedException();
        }
        [HttpDelete]
        [Route("[action]")]
        public Task DeleteJobOpportunity(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
