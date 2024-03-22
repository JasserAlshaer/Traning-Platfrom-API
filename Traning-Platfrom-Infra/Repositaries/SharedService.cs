using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Context;
using Traning_Platfrom_Core.Dtos.JobField;
using Traning_Platfrom_Core.Dtos.JobOpportunity;

using Traning_Platfrom_Core.Dtos.OrganizationDTO;
using Traning_Platfrom_Core.Dtos.Testimonal;
using Traning_Platfrom_Core.Entity.Lookups;
using Traning_Platfrom_Core.Entity.Company;
using Traning_Platfrom_Core.IRepositaries;
using static Traning_Platfrom_Core.Enums.Enums;
using Traning_Platfrom_Core.Dtos.StaticPage;
using Traning_Platfrom_Core.Dtos.JobSeeker;
using Traning_Platfrom_Core.Helper;

namespace Traning_Platfrom_Infra.Repositaries
{
    public class SharedService : ISharedService
    {
        private readonly TrainingPlatformDbContext _context;
        public SharedService(TrainingPlatformDbContext context)
        {
            _context = context;
        }

        public async Task<AboutUsDTO> GetAboutUsDTOAsync()
        {
            AboutUsDTO aboutUsDTO=new AboutUsDTO();
            aboutUsDTO.OrganizationCount = await _context.Organizations.Where(x => x.IsDeleted == false).CountAsync();
            aboutUsDTO.JobCount = await _context.JobOpportunities.Where(x => x.IsDeleted == false).CountAsync();
            aboutUsDTO.JobSeekerCount = await _context.JobSeekers.Where(x => x.IsDeleted == false).CountAsync();

            return aboutUsDTO;
        }

        public async Task<List<JobFieldDTO>> GetJobFieldsAsync()
        {
            var res = from field in _context.JobFields
                      where field.IsDeleted == false
                      orderby field.Title ascending
                      select new JobFieldDTO
                      {
                          Id = field.Id,
                          Title = field.Title,
                          Image = field.Image,
                          JobCounting = _context.JobOpportunities.Where(x => x.JobField.Id == field.Id).Count(),
                      };
            return await res.ToListAsync();
        }

        public async Task<List<JobOpportunityCardDTO>> GetJobOpportunityAsync()
        {
            var res = from job in _context.JobOpportunities
                      join org in _context.Organizations
                      on job.Organization.Id equals org.Id
                      where job.IsDeleted == false
                      orderby job.CreationDate descending
                      select new JobOpportunityCardDTO
                      {
                          Title = job.Title,
                          Description = job.Description,
                          Country = job.Country,
                          City = job.City,
                          Region = job.Region,
                          JobLevel = job.JobLevel.ToString(),
                          JobType = job.JobType.ToString(),
                          OrganizationId = org.Id,
                          OrganizationName = org.Name,
                          OrganizationProfileImage = org.ProfileImage
                      };
            return await res.ToListAsync();
        }

        public async Task<List<OrganizationDTO>> GetOrganizationAsync()
        {
            var res = from org in _context.Organizations
                      where org.IsDeleted == false
                      orderby org.CreationDate descending
                      select new OrganizationDTO
                      {
                          Name = org.Name,
                          Pio = org.Pio,
                          Address = org.Address,
                          Email = org.Email,
                          ProfileImage = org.ProfileImage,
                          PreviewVideoPath = org.PreviewVideoPath,
                          YearFounded = org.YearFounded,
                          GitHubLink = org.GitHubLink,
                          FaceBookLink = org.FaceBookLink,
                          TwitterLink = org.TwitterLink,
                          LinkdeInLink = org.LinkdeInLink
                      };
            return await res.ToListAsync();
        }

        public async Task<List<Skill>> GetSkillsAsync()
        {
            var res = await _context.Skills.ToListAsync();
            return res;
        }

        public async Task<List<TestimonalDTO>> GetTestimonialsAsync()
        {
            var res = from tes in _context.Testimonials
                      join jobseeker in _context.JobSeekers
                      on tes.JobSeeker.Id equals jobseeker.Id
                      where tes.IsDeleted == false
                      orderby tes.CreationDate descending
                      select new TestimonalDTO
                      {
                          Id = tes.Id,
                          JobSeekerName = $"{jobseeker.FirstName} {jobseeker.SecondName} {jobseeker.LastName}",
                          Major = "",
                          Comment = tes.Comment,
                          RateCount = tes.RateCount,
                          Image = jobseeker.ProfileImagePath
                      };
            return await res.ToListAsync();
        }

        public async Task<List<TopJobSeekerDTO>> GetTopJobSeekersAsync()
        {
            var res = from jobseeker in _context.JobSeekers
                      where jobseeker.IsDeleted == false
                      select new TopJobSeekerDTO
                      {
                          Id=jobseeker.Id,  
                          Image=jobseeker.ProfileImagePath,
                          JobTitle = jobseeker.JobTitle,    
                          Name = $"{jobseeker.FirstName} {jobseeker.SecondName} {jobseeker.LastName}"
                      };
            var list= await res.ToListAsync();
            foreach (var item in list)
            {
                var experinices =await _context.Experiences.Where(x => x.JobSeeker.Id == item.Id).ToListAsync();
                int sum = 0;
                foreach(var ex in experinices)
                {
                    sum += ServiceHelper.CalculateDaysDifference(ex.StartDate, ex.EndDate);
                }
                item.ExperienceInDays = sum;
            }
            return list.OrderByDescending(x=>x.ExperienceInDays).Take(4).ToList();
        }

        public async Task<List<OrganizationCardDTO>> GetTopOrganizationAsync()
        {
            var res = from org in _context.Organizations
                      join field in _context.JobFields
                      on org.JobField.Id equals field.Id
                      where org.IsDeleted == false
                      orderby org.CreationDate descending
                      select new OrganizationCardDTO
                      {
                          Id= org.Id,
                          Name= org.Name,
                          City=org.City.ToString(),
                          Field= field.Title,
                          Image=org.ProfileImage
                      };
            return await res.ToListAsync();
        }
    }
}
