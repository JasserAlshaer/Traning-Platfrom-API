using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Traning_Platfrom_Core.Dtos.EducationHistory;
using Traning_Platfrom_Core.Dtos.Experience;
using Traning_Platfrom_Core.Dtos.JobApplication;
using Traning_Platfrom_Core.Dtos.JobInterview;
using Traning_Platfrom_Core.Dtos.JobSeeker;
using Traning_Platfrom_Core.Dtos.Skills;
using Traning_Platfrom_Core.IRepositaries;

namespace Traning_Platfrom_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobSeekerController : ControllerBase
    {
        private readonly IJobSeekerService _service;
        public JobSeekerController(IJobSeekerService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("[action]")]
        public Task<List<JobInterviewDTO>> GetMyInterview()
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        [Route("[action]")]
        public Task<List<JobApplicationDTO>> GetMyJobApplication()
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [Route("[action]")]
        public Task CompleteProfile(CompleteJobSeekerProfileDTO dto)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [Route("[action]")]
        public Task CreateEducationHistory(EducationHistoryDTO dto)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [Route("[action]")]
        public Task CreateExperience(ExperienceDTO dto)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [Route("[action]")]
        public Task CreateJobSeekerSkill(CreateJobSeekerSkill dto)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [Route("[action]")]
        public Task SendJobApplication(CreateJobApplicationDTO dto)
        {
            throw new NotImplementedException();
        }
        [HttpPut]
        [Route("[action]")]
        public Task UpdateEducationHistory(EducationHistoryDTO dto)
        {
            throw new NotImplementedException();
        }
        [HttpPut]
        [Route("[action]")]
        public Task UpdateExperience(ExperienceDTO dto)
        {
            throw new NotImplementedException();
        }
        [HttpDelete]
        [Route("[action]")]
        public Task DeleteEducationHistory(int Id)
        {
            throw new NotImplementedException();
        }
        [HttpDelete]
        [Route("[action]")]
        public Task DeleteExperience(int Id)
        {
            throw new NotImplementedException();
        }
        [HttpDelete]
        [Route("[action]")]
        public Task DeleteJobSeekerSkill(int Id)
        {
            throw new NotImplementedException();
        }

    }
}
