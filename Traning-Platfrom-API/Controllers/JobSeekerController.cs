using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Traning_Platfrom_Core.Dtos.EducationHistory;
using Traning_Platfrom_Core.Dtos.Experience;
using Traning_Platfrom_Core.Dtos.JobApplication;
using Traning_Platfrom_Core.Dtos.JobInterview;
using Traning_Platfrom_Core.Dtos.JobOpportunity;
using Traning_Platfrom_Core.Dtos.JobSeeker;
using Traning_Platfrom_Core.Dtos.JobSeeker.Profile;
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
        public async Task<JobInterviewDTO> GetMyInterviewById(int Id)
        {
            return await _service.GetMyInterviewByIdAsync(Id);
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
        [HttpGet]
        [Route("[action]")]
        public async Task<string> CheckIfPreAppliedByJobIdAndJobSeekerId(int jobId, int jobSeekerId)
        {
            return await _service.CheckIfPreAppliedByJobIdAndJobSeekerIdAsync(jobId, jobSeekerId);
        }
        [HttpPost]
        [Route("[action]")]
        public async Task CompleteProfile(CompleteJobSeekerProfileDTO dto)
        {
            await _service.CompleteProfileAsync(dto);
        }
        [HttpPost]
        [Route("[action]")]
        public async Task CreateEducationHistory(EducationHistoryDTO dto)
        {
            await _service.CreateEducationHistoryAsync(dto);
        }
        [HttpPost]
        [Route("[action]")]
        public async Task CreateExperience(ExperienceDTO dto)
        {
            await _service.CreateExperienceAsync(dto);
        }
        [HttpPost]
        [Route("[action]")]
        public async Task CreateJobSeekerSkill(CreateJobSeekerSkill dto)
        {
            await _service.CreateJobSeekerSkillAsync(dto);
        }
        [HttpPost]
        [Route("[action]")]
        public async Task SendJobApplication(CreateJobApplicationDTO dto)
        {
            await _service.SendJobApplicationAsync(dto);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task UpdateEducationHistory(EducationHistoryDTO dto)
        {
            await _service.UpdateEducationHistoryAsync(dto);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task UpdateExperience(ExperienceDTO dto)
        {
            await _service.UpdateExperienceAsync(dto);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task UpdateJobSeekerMainInfo(MainInfoDTO dto)
        {
            await _service.UpdateJobSeekerMainInfoAsync(dto);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task UpdateJobSeekerSocialInfo(SocialMediaDTO dto)
        {
            await _service.UpdateJobSeekerSocialInfoAsync(dto);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task UpdateJobSeekerContactInfo(ContactDTO dto)
        {
            await _service.UpdateJobSeekerContactInfoAsync(dto);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task UpdateJobSeekerProfileImage(ProfileImageDTO dto)
        {
            await _service.UpdateJobSeekerProfileImageAsync(dto);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task UpdateJobSeekerProfileResume(ProfileResumeDTO dto)
        {
            await _service.UpdateJobSeekerProfileResumeFileAsync(dto);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task UpdateJobSeekerResumeInfo(ResumeDTO dto)
        {
            await _service.UpdateJobSeekerResumeInfoAsync(dto);
        }
        [HttpDelete]
        [Route("[action]")]
        public async Task DeleteEducationHistory(int Id)
        {
            await _service.DeleteEducationHistoryAsync(Id);
        }
        [HttpDelete]
        [Route("[action]")]
        public async Task DeleteExperience(int Id)
        {
            await _service.DeleteExperienceAsync(Id);
        }
        [HttpDelete]
        [Route("[action]")]
        public async Task DeleteJobSeekerSkill(int Id)
        {
            await _service.DeleteJobSeekerSkillAsync(Id);
        }

    }
}
