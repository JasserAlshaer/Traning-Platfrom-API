using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Context;
using Traning_Platfrom_Core.Dtos.EducationHistory;
using Traning_Platfrom_Core.Dtos.Experience;
using Traning_Platfrom_Core.Dtos.JobApplication;
using Traning_Platfrom_Core.Dtos.JobInterview;
using Traning_Platfrom_Core.Dtos.JobSeeker;
using Traning_Platfrom_Core.Dtos.Skills;
using Traning_Platfrom_Core.IRepositaries;

namespace Traning_Platfrom_Infra.Repositaries
{
    public class JobSeekerService : IJobSeekerService
    {
        private readonly TrainingPlatformDbContext _context;
        public JobSeekerService(TrainingPlatformDbContext context)
        {
            _context = context;
        }

        public Task CompleteProfileAsync(CompleteJobSeekerProfileDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task CreateEducationHistoryAsync(EducationHistoryDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task CreateExperienceAsync(ExperienceDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task CreateJobSeekerSkillAsync(CreateJobSeekerSkill dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEducationHistoryAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteExperienceAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteJobSeekerSkillAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<JobInterviewDTO>> GetMyInterviewAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<JobApplicationDTO>> GetMyJobApplicationAsync()
        {
            throw new NotImplementedException();
        }

        public Task SendJobApplicationAsync(CreateJobApplicationDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEducationHistoryAsync(EducationHistoryDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateExperienceAsync(ExperienceDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
