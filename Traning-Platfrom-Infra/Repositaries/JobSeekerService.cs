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
using Traning_Platfrom_Core.IRepositaries;

namespace Traning_Platfrom_Infra.Repositaries
{
    public class JobSeekerService : IJobSeekerService
    {
        public Task CompleteProfile(CompleteJobSeekerProfileDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task CreateEducationHistory(EducationHistoryDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task CreateExperience(ExperienceDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task CreateJobSeekerSkill(CreateJobSeekerSkill dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEducationHistory(int Id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteExperience(int Id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteJobSeekerSkill(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<JobInterviewDTO>> GetMyInterview()
        {
            throw new NotImplementedException();
        }

        public Task<List<JobApplicationDTO>> GetMyJobApplication()
        {
            throw new NotImplementedException();
        }

        public Task SendJobApplication(CreateJobApplicationDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEducationHistory(EducationHistoryDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateExperience(ExperienceDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
