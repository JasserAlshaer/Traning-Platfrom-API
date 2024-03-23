using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Context;
using Traning_Platfrom_Core.Dtos.JobApplication;
using Traning_Platfrom_Core.Dtos.JobInterview;
using Traning_Platfrom_Core.Dtos.JobOpportunity;
using Traning_Platfrom_Core.Dtos.OrganizationDTO;
using Traning_Platfrom_Core.Entity.Lookups;
using Traning_Platfrom_Core.Entity.Company;
using Traning_Platfrom_Core.IRepositaries;
using static Traning_Platfrom_Core.Enums.Enums;

namespace Traning_Platfrom_Infra.Repositaries
{
    public class OrganizationService : IOrganizationService
    {
        private readonly TrainingPlatformDbContext _context;
        public OrganizationService(TrainingPlatformDbContext context)
        {
            _context = context;
        }
        public async Task CompleteOrganizationProfileAsync(CreateOrganizationDTO dto)
        {
            var org = await _context.Organizations.FirstOrDefaultAsync(x => x.Id == dto.Id);
            if (org != null)
            {
                org.Pio = dto.Pio;
                org.Address = dto.Address;
                org.Email = dto.Email;
                org.ProfileImage = dto.ProfileImage;
                org.PreviewVideoPath = dto.PreviewVideoPath;
                org.YearFounded = dto.YearFounded;
                org.GitHubLink = dto.GitHubLink;
                org.FaceBookLink = dto.FaceBookLink;
                org.TwitterLink = dto.TwitterLink;
                org.LinkdeInLink = dto.LinkdeInLink;
                _context.Update(org);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Organization Not Found");
            }
        }

        public async Task CreateJobInterviewAsync(CreateJobInterviewDTO dto)
        {
            var jobSeeker = await _context.JobSeekers.FirstOrDefaultAsync(x => x.Id == dto.JobSeekerId);
            var opportunity = await _context.JobOpportunities.FirstOrDefaultAsync(x => x.Id == dto.JobOpportunityId);
            JobInterview jobInterview = new JobInterview()
            {
                Title = dto.Title,
                Note = dto.Note,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                InterviewType = dto.InterviewType,
                JobSeeker = jobSeeker,
                Opportunity = opportunity
            };
            await _context.AddAsync(jobInterview);
            await _context.SaveChangesAsync();
        }

        public async Task CreateJobOpportunityAsync(JobOpportunityCardDTO dto)
        {
            var org = await _context.Organizations.FirstOrDefaultAsync(x => x.Id == dto.OrganizationId);
            var field = await _context.JobFields.FirstOrDefaultAsync(x => x.Id == dto.JobFieldId);
            JobOpportunity jobOpportunity = new JobOpportunity()
            {
                Title = dto.Title,
                Description = dto.Description,
                Country = dto.Country,
                City = dto.City,
                EducationCertificationType = (EducationCertificationType)Enum.Parse(typeof(EducationCertificationType), dto.Qualification),
                JobLevel = (JobLevel)Enum.Parse(typeof(JobLevel), dto.JobLevel),
                JobType = (JobType)Enum.Parse(typeof(JobType), dto.JobType),
                JobLocation = (JobLocation)Enum.Parse(typeof(JobLocation), dto.JobLocation),
                Gender = (Gender)Enum.Parse(typeof(Gender), dto.Gender),
                Organization = org,
                JobField=field
                //Region = dto.Region,
                //Skills = dto.Skills,
                //Responsability = dto.Responsability,
                //JobPrivileges = dto.JobPrivileges,
                //OtherApplicationCondition = dto.OtherApplicationCondition,
                //IsMustHaveDrivingLicense = dto.IsMustHaveDrivingLicense,
                //MinAmountOfSkills = dto.MinAmountOfSkills,
                //ExperienceCount = dto.ExperienceCount,
                //MinGPA = dto.MinGPA,
                //JobApplicationStatus = dto.JobApplicationStatus,

            };
            await _context.AddAsync(jobOpportunity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteJobInterviewAsync(int Id)
        {
            var entity = await _context.JobInterviews.FirstOrDefaultAsync(x => x.Id == Id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                _context.Update(entity);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Experience Not Found");
            }
        }

        public async Task DeleteJobOpportunityAsync(int Id)
        {
            var entity = await _context.JobOpportunities.FirstOrDefaultAsync(x => x.Id == Id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                _context.Update(entity);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Experience Not Found");
            }
        }

        public async Task<List<JobInterviewDetailsDTO>> GetAllJobInterviewAsync(int Id)
        {
            var res = from inteview in _context.JobInterviews
                      join job in _context.JobOpportunities
                      on inteview.Opportunity.Id equals job.Id
                      join org in _context.Organizations
                      on job.Organization.Id equals org.Id
                      join jobseeker in _context.JobSeekers
                      on inteview.JobSeeker.Id equals jobseeker.Id
                      where org.Id == Id
                      select new JobInterviewDetailsDTO
                      {
                          Id = inteview.Id,
                          Title = inteview.Title,
                          Note = inteview.Note,
                          StartDate = inteview.StartDate,
                          EndDate = inteview.EndDate,
                          InterviewType = inteview.InterviewType,
                          JobOpportunityTitle = job.Title,
                          JobLevel = job.JobLevel.ToString(),
                          JobType = job.JobType.ToString(),
                          JobSeekerName = $"{jobseeker.FirstName} {jobseeker.SecondName} {jobseeker.LastName}",
                          JobSeekerEmail = jobseeker.EmailAddress,
                          JobSeekerPhone = jobseeker.Phone,
                          JobSeekerImage = jobseeker.ProfileImagePath,
                          JobSeekerResume = jobseeker.ResumeFilePath
                      };
            return await res.ToListAsync();
        }

        public async Task<List<JobApplicationDetailsDTO>> GetJobApplicationAsync(int Id)
        {
            var res = from application in _context.JobApplications
                      join job in _context.JobOpportunities
                      on application.JobOpportunity.Id equals job.Id
                      join org in _context.Organizations
                      on job.Organization.Id equals org.Id
                      join jobseeker in _context.JobSeekers
                      on application.JobSeeker.Id equals jobseeker.Id
                      where job.Id == Id
                      select new JobApplicationDetailsDTO
                      {
                          Id = job.Id,
                          JobLevel = job.JobLevel.ToString(),
                          JobOpportunityTitle = job.Title,
                          JobType = job.JobType.ToString(),
                          JobSeekerId = jobseeker.Id,
                          JobSeekerName = $"{jobseeker.FirstName} {jobseeker.SecondName} {jobseeker.LastName}",
                          JobSeekerEmail = jobseeker.EmailAddress,
                          JobSeekerPhone = jobseeker.Phone,
                          JobSeekerImage = jobseeker.ProfileImagePath,
                          JobSeekerResume = jobseeker.ResumeFilePath,
                          JobSeekerMajor = jobseeker.Major,
                          JobSeekerQulification=jobseeker.Qualification.ToString(), 
                      };
            return await res.ToListAsync();
        }

        public async Task<List<JobOpportunityCardDTO>> GetJobOpportunityByOrganizationIdAsync(int Id)
        {
            var res = from job in _context.JobOpportunities
                      join org in _context.Organizations
                      on job.Organization.Id equals org.Id
                      join field in _context.JobFields
                      on job.JobField.Id equals field.Id
                      where job.IsDeleted == false && org.Id == Id
                      orderby job.CreationDate descending
                      select new JobOpportunityCardDTO
                      {
                          Id= job.Id,
                          Title = job.Title,
                          Description = job.Description,
                          Country = job.Country,
                          City = job.City,
                          Region = job.Region,
                          JobLevel = job.JobLevel.ToString(),
                          JobType = job.JobType.ToString(),
                          OrganizationId = org.Id,
                          OrganizationName = org.Name,
                          OrganizationProfileImage = org.ProfileImage,
                          CreationDate=job.CreationDate,
                          JobFieldId= field.Id,
                          JobField= field.Title,
                          Gender=job.Gender.ToString(),
                          Qualification=job.EducationCertificationType.ToString(),
                          JobLocation=job.JobLocation.ToString(),

                      };
            var obj = await res.ToListAsync();
            foreach(var item in obj) {
                item.ApplicationAmount = await _context.JobApplications.Where(x =>x.JobOpportunity.Id == item.Id &&x.JobOpportunity.Organization.Id == Id).CountAsync();
            }
            return obj;
        }

        public async Task<OrganizationDTO> GetOrganizationDTOAsync(int Id)
        {
            var res = from org in _context.Organizations
                      join field in _context.JobFields
                      on org.JobField.Id equals field.Id
                      where org.IsDeleted == false && org.Id == Id
                      orderby org.CreationDate descending
                      select new OrganizationDTO
                      {
                          Id=org.Id,
                          Name = org.Name,
                          Pio = org.Pio,
                          Address = org.Address,
                          Email = org.Email,
                          Phone=org.Phone,
                          ProfileImage = org.ProfileImage,
                          PreviewVideoPath = org.PreviewVideoPath,
                          YearFounded = org.YearFounded,
                          GitHubLink = org.GitHubLink,
                          FaceBookLink = org.FaceBookLink,
                          TwitterLink = org.TwitterLink,
                          LinkdeInLink = org.LinkdeInLink,
                          JobField = field.Title,
                          TeamSize=org.TeamSize,
                          City=org.City.ToString(),
                          Country=org.Country.ToString(),
                          WebsiteUrl=org.WebsiteUrl,
                          jobFieldId=field.Id,
                      };
            var obj = await res.SingleOrDefaultAsync();
            obj.JobsCount = await _context.JobOpportunities.Where(x => x.Organization.Id == Id).CountAsync();
            return obj;
        }

        public async Task<OrganizationStatisticsDTO> GetOrganizationStatisticsAsync(int Id)
        {
            OrganizationStatisticsDTO statisticsDTO = new OrganizationStatisticsDTO();
            statisticsDTO.Notifications = 0;
            statisticsDTO.Applications = await _context.JobApplications.Where(x=>x.JobOpportunity.Organization.Id==Id).CountAsync();
            statisticsDTO.Jobs = await _context.JobOpportunities.Where(x => x.Organization.Id == Id).CountAsync();
            statisticsDTO.Interview = await _context.JobInterviews.Where(x => x.Opportunity.Organization.Id == Id).CountAsync();

            return statisticsDTO;
        }

        public async Task<List<JobApplicationDTO>> GetTopApplicantAsync()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateJobInterviewAsync(CreateJobInterviewDTO dto)
        {
            var entity = await _context.JobInterviews.FirstOrDefaultAsync(x => x.Id == dto.Id);
            if (entity != null)
            {
                entity.Title = dto.Title;
                entity.Note = dto.Note;
                entity.StartDate = dto.StartDate;
                entity.EndDate = dto.EndDate;
                entity.InterviewType = dto.InterviewType;
                _context.Update(entity);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Experience Not Found");
            }
        }

        public async Task UpdateJobOpportunityAsync(JobOpportunityCardDTO dto)
        {
            var entity = await _context.JobOpportunities.FirstOrDefaultAsync(x => x.Id == dto.Id);
            if (entity != null)
            {
                var org = await _context.Organizations.FirstOrDefaultAsync(x => x.Id == dto.OrganizationId);
            var field = await _context.JobFields.FirstOrDefaultAsync(x => x.Id == dto.JobFieldId);
                entity.Title = dto.Title;
                entity.Description = dto.Description;
                entity.Country = dto.Country;
                entity.City = dto.City;
                entity.EducationCertificationType = (EducationCertificationType)Enum.Parse(typeof(EducationCertificationType), dto.Qualification);
                entity.JobLevel = (JobLevel)Enum.Parse(typeof(JobLevel), dto.JobLevel);
                entity.JobType = (JobType)Enum.Parse(typeof(JobType), dto.JobType);
                entity.JobLocation = (JobLocation)Enum.Parse(typeof(JobLocation), dto.JobLocation);
                entity.Gender = (Gender)Enum.Parse(typeof(Gender), dto.Gender);
                entity.Organization = org;
                entity.JobField = field;
                _context.Update(entity);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Experience Not Found");
            }
        }

        public async Task UpdateOrganizationSocialInfoAsync(OrganizationSocialMediaDTO dto)
        {
            var profile = await _context.Organizations.FirstOrDefaultAsync(x => x.Id == dto.OrganizationId);
            if (profile != null)
            {
                profile.FaceBookLink = dto.FaceBookLink;
                profile.LinkdeInLink = dto.LinkedInLink;
                profile.TwitterLink = dto.TwitterLink;
                profile.WebsiteUrl = dto.WebsiteUrl;
                _context.Update(profile);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Organization Not Found");
            }
        }
        public async Task UpdateOrganizationContactInfoAsync(OrganizationContactDTO dto)
        {
            var profile = await _context.Organizations.FirstOrDefaultAsync(x => x.Id == dto.OrganizationId);
            if (profile != null)
            {
                profile.Country = dto.Country;
                profile.City = (Cities)Enum.Parse(typeof(Cities),dto.City);
                profile.Address = dto.Address;
                _context.Update(profile);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Organization Not Found");
            }
        }
        public async Task UpdateOrganizationProfileImageAsync(OrganizationProfileImageDTO dto)
        {
            var profile = await _context.Organizations.FirstOrDefaultAsync(x => x.Id == dto.OrganizationId);
            if (profile != null)
            {
                profile.ProfileImage = dto.Image;
                _context.Update(profile);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Organization Not Found");
            }
        }
        public async Task UpdateOrganizationMainInfoAsync(OrganizationMainInfoDTO dto)
        {
            var profile = await _context.Organizations.FirstOrDefaultAsync(x => x.Id == dto.OrganizationId);
            if (profile != null)
            {
                profile.Name = dto.Name;
                profile.Email = dto.Email;
                profile.Phone = dto.Phone;
                profile.YearFounded = dto.YearFounded;
                profile.TeamSize = dto.TeamSize;
                profile.JobField = await _context.JobFields.FindAsync(dto.CategoryId);
                profile.Pio = dto.About;
                _context.Update(profile);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Organization Not Found");
            }
        }

    }
}
