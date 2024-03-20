using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Dtos.EducationHistory;
using Traning_Platfrom_Core.Dtos.Experience;
using Traning_Platfrom_Core.Dtos.JobApplication;
using Traning_Platfrom_Core.Dtos.JobInterview;
using Traning_Platfrom_Core.Dtos.JobSeeker;
using Traning_Platfrom_Core.Dtos.Skills;

namespace Traning_Platfrom_Core.IRepositaries
{
    public interface IJobSeekerService
    {
        Task CompleteProfile(CompleteJobSeekerProfileDTO dto);
        Task CreateEducationHistory(EducationHistoryDTO dto);
        Task UpdateEducationHistory(EducationHistoryDTO dto);
        Task DeleteEducationHistory(int Id);
        Task CreateExperience(ExperienceDTO dto);
        Task UpdateExperience(ExperienceDTO dto);
        Task DeleteExperience(int Id);
        Task CreateJobSeekerSkill(CreateJobSeekerSkill dto);
        Task DeleteJobSeekerSkill(int Id);
        Task SendJobApplication(CreateJobApplicationDTO dto);
        Task<List<JobApplicationDTO>> GetMyJobApplication();
        Task<List<JobInterviewDTO>> GetMyInterview();

    }
}
