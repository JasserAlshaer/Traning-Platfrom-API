using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_Platfrom_Core.IRepositaries
{
    public interface IJobSeekerService
    {
        Task CompleteProfile();
        Task UpdateProfile();
        Task CreateEducationHistory();
        Task UpdateEducationHistory();
        Task DeleteEducationHistory();
        Task CreateExperience();
        Task UpdateExperience();
        Task DeleteExperience();
        Task CreateJobSeekerSkill();
        Task UpdateJobSeekerSkill();
        Task DeleteJobSeekerSkill();
        Task SendJobApplication();
        Task GetMyJobApplication();
        Task GetMyInterview();

    }
}
