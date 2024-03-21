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

        public async Task CompleteProfileAsync(CompleteJobSeekerProfileDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task CreateEducationHistoryAsync(EducationHistoryDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task CreateExperienceAsync(ExperienceDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task CreateJobSeekerSkillAsync(CreateJobSeekerSkill dto)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteEducationHistoryAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteExperienceAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteJobSeekerSkillAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<JobInterviewDTO>> GetMyInterviewAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<JobApplicationDTO>> GetMyJobApplicationAsync()
        {
            throw new NotImplementedException();
        }

        public async Task SendJobApplicationAsync(CreateJobApplicationDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateEducationHistoryAsync(EducationHistoryDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateExperienceAsync(ExperienceDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
