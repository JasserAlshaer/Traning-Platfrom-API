using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Dtos.JobApplication;
using Traning_Platfrom_Core.Dtos.JobField;
using Traning_Platfrom_Core.Dtos.JobOpportunity;
using Traning_Platfrom_Core.Dtos.JobSeeker;
using Traning_Platfrom_Core.Dtos.OrganizationDTO;
using Traning_Platfrom_Core.Dtos.StaticPage;
using Traning_Platfrom_Core.Dtos.Testimonal;
using Traning_Platfrom_Core.Entity.Lookups;

namespace Traning_Platfrom_Core.IRepositaries
{
    public interface ISharedService
    {
        Task<List<JobOpportunityCardDTO>> GetJobOpportunityAsync();
        Task<List<JobOpportunityCardDTO>> GetJobOpportunityByJobFieldIdAsync(int Id);
        Task<List<OrganizationDTO>> GetOrganizationAsync();
        Task<List<OrganizationCardDTO>> GetTopOrganizationAsync();
        Task<List<Skill>> GetSkillsAsync();
        Task<List<JobFieldDTO>> GetJobFieldsAsync();
        Task<List<TestimonalDTO>> GetTestimonialsAsync();
        Task<AboutUsDTO>GetAboutUsDTOAsync();
        Task<List<TopJobSeekerDTO>> GetTopJobSeekersAsync();
        Task<JobOpportunityDTO> GetJobOpportunityDetailsByIdAsync(int Id);
    }
}
