using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Dtos.EducationHistory;
using Traning_Platfrom_Core.Dtos.Experience;
using Traning_Platfrom_Core.Dtos.JobApplication;
using Traning_Platfrom_Core.Dtos.JobInterview;
using Traning_Platfrom_Core.Dtos.JobOpportunity;
using Traning_Platfrom_Core.Dtos.JobSeeker;
using Traning_Platfrom_Core.Dtos.JobSeeker.Profile;
using Traning_Platfrom_Core.Dtos.JobSeeker.Resume;
using Traning_Platfrom_Core.Dtos.Skills;

namespace Traning_Platfrom_Core.IRepositaries
{
    public interface IJobSeekerService
    {
        Task CompleteProfileAsync(CompleteJobSeekerProfileDTO dto);
        Task CreateEducationHistoryAsync(EducationHistoryDTO dto);
        Task UpdateEducationHistoryAsync(EducationHistoryDTO dto);
        Task DeleteEducationHistoryAsync(int Id);
        Task CreateExperienceAsync(ExperienceDTO dto);
        Task UpdateExperienceAsync(ExperienceDTO dto);
        Task UpdateJobSeekerMainInfoAsync(MainInfoDTO dto);
        Task UpdateJobSeekerSocialInfoAsync(SocialMediaDTO dto);
        Task UpdateJobSeekerContactInfoAsync(ContactDTO dto);
        Task UpdateJobSeekerProfileImageAsync(ProfileImageDTO dto);
        Task UpdateJobSeekerProfileResumeFileAsync(ProfileResumeDTO dto);
        Task UpdateJobSeekerResumeInfoAsync(ResumeDTO dto);
        Task DeleteExperienceAsync(int Id);
        Task CreateJobSeekerSkillAsync(CreateJobSeekerSkill dto);
        Task DeleteJobSeekerSkillAsync(int Id);
        Task SendJobApplicationAsync(CreateJobApplicationDTO dto);
        Task<JobInterviewDTO> GetMyInterviewByIdAsync(int Id);
        Task<List<JobOpportunityCardDTO>> GetMyJobApplicationAsync(int Id);
        Task<JobSeekerCompleteProfileDTO> GetJobSeekerCompleteProfileAsync(int Id);
        Task<ProfileDTO> GetJobSeekerProfileByIdAsync(int Id);
        Task<ResumeDTO> GetJobSeekerResumeByIdAsync(int Id);
        Task<List<ExperienceDTO>> GetJobSeekerExperiencesByIdAsync(int Id);
        Task<List<EducationHistoryDTO>> GetJobSeekerEducationHistoryByIdAsync(int Id);
        Task<string> CheckIfPreAppliedByJobIdAndJobSeekerIdAsync(int jobId, int jobSeekerId);
    }
}
