using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_Platfrom_Core.IRepositaries
{
    public interface IOrganizationService
    {
        Task CompleteOrganizationProfile();
        Task CreateJobOpportunity();
        Task UpdateJobOpportunity();
        Task DeleteJobOpportunity();
        Task CreateJobInterview();
        Task UpdateJobInterview();
        Task DeleteJobInterview();
        Task GetJobApplication();
        Task GetTopApplicant();
        Task GetAllInterview();
        Task GetAllJobInterview();
    }
}
