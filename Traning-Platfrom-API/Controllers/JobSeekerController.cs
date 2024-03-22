using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Traning_Platfrom_Core.Dtos.EducationHistory;
using Traning_Platfrom_Core.Dtos.Experience;
using Traning_Platfrom_Core.Dtos.JobApplication;
using Traning_Platfrom_Core.Dtos.JobInterview;
using Traning_Platfrom_Core.Dtos.JobOpportunity;
using Traning_Platfrom_Core.Dtos.JobSeeker;
using Traning_Platfrom_Core.Dtos.JobSeeker.Resume;
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
            return _service.GetMyInterviewAsync();
        }
        [HttpGet]
        [Route("[action]")]
        public Task<List<JobOpportunityCardDTO>> GetMyJobApplication(int Id)
        {
            return _service.GetMyJobApplicationAsync(Id);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<JobSeekerCompleteProfileDTO> GetJobSeekerCompleteProfile(int Id)
        {
            return await _service.GetJobSeekerCompleteProfileAsync(Id);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<ProfileDTO> GetJobSeekerProfileById(int Id)
        {
            return await _service.GetJobSeekerProfileByIdAsync(Id);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<ResumeDTO> GetJobSeekerResumeById(int Id)
        {
            return await _service.GetJobSeekerResumeByIdAsync(Id);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<List<ExperienceDTO>> GetJobSeekerExperiencesById(int Id)
        {
            return await _service.GetJobSeekerExperiencesByIdAsync(Id);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<List<EducationHistoryDTO>> GetJobSeekerEducationHistoryById(int Id)
        {
            return await _service.GetJobSeekerEducationHistoryByIdAsync(Id);
        }
        [HttpPost]
        [Route("[action]")]
        public Task CompleteProfile(CompleteJobSeekerProfileDTO dto)
        {
            return _service.CompleteProfileAsync(dto);
        }
        [HttpPost]
        [Route("[action]")]
        public Task CreateEducationHistory(EducationHistoryDTO dto)
        {
            return _service.CreateEducationHistoryAsync(dto);
        }
        [HttpPost]
        [Route("[action]")]
        public Task CreateExperience(ExperienceDTO dto)
        {
            return _service.CreateExperienceAsync(dto);
        }
        [HttpPost]
        [Route("[action]")]
        public Task CreateJobSeekerSkill(CreateJobSeekerSkill dto)
        {
            return _service.CreateJobSeekerSkillAsync(dto);
        }
        [HttpPost]
        [Route("[action]")]
        public Task SendJobApplication(CreateJobApplicationDTO dto)
        {
            return _service.SendJobApplicationAsync(dto);
        }
        [HttpPut]
        [Route("[action]")]
        public Task UpdateEducationHistory(EducationHistoryDTO dto)
        {
            return _service.UpdateEducationHistoryAsync(dto);
        }
        [HttpPut]
        [Route("[action]")]
        public Task UpdateExperience(ExperienceDTO dto)
        {
            return _service.UpdateExperienceAsync(dto);
        }
        [HttpDelete]
        [Route("[action]")]
        public Task DeleteEducationHistory(int Id)
        {
            return _service.DeleteEducationHistoryAsync(Id);
        }
        [HttpDelete]
        [Route("[action]")]
        public Task DeleteExperience(int Id)
        {
            return _service.DeleteExperienceAsync(Id);
        }
        [HttpDelete]
        [Route("[action]")]
        public Task DeleteJobSeekerSkill(int Id)
        {
            return _service.DeleteJobSeekerSkillAsync(Id);
        }

    }
}
