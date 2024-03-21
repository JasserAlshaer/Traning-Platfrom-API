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
using Traning_Platfrom_Core.Entity.Organization;
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
            var opportunity = await _context.JobOpportunities.FirstOrDefaultAsync(x => x.Id == dto.JonOpportunityId);
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

        public async Task CreateJobOpportunityAsync(CreateJobOpportunityDTO dto)
        {
            var org = await _context.Organizations.FirstOrDefaultAsync(x => x.Id == dto.OrganizationId);
            JobOpportunity jobOpportunity = new JobOpportunity()
            {
                Title = dto.Title,
                Description = dto.Description,
                Country = dto.Country,
                City = dto.City,
                Region = dto.Region,
                Skills = dto.Skills,
                Responsability = dto.Responsability,
                JobPrivileges = dto.JobPrivileges,
                JobLocation = dto.JobLocation,
                OtherApplicationCondition = dto.OtherApplicationCondition,
                Gender = dto.Gender,
                IsMustHaveDrivingLicense = dto.IsMustHaveDrivingLicense,
                MinAmountOfSkills = dto.MinAmountOfSkills,
                ExperienceCount = dto.ExperienceCount,
                MinGPA = dto.MinGPA,
                EducationCertificationType = dto.EducationCertificationType,
                JobLevel = dto.JobLevel,
                JobType = dto.JobType,
                JobApplicationStatus = dto.JobApplicationStatus,
                Organization = org
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
                      where org.Id == Id
                      select new JobApplicationDetailsDTO
                      {
                          Id = job.Id,
                          JobLevel = job.JobLevel.ToString(),
                          JobOpportunityTitle = job.Title,
                          JobType = job.JobType.ToString(),
                          JobSeekerName = $"{jobseeker.FirstName} {jobseeker.SecondName} {jobseeker.LastName}",
                          JobSeekerEmail = jobseeker.EmailAddress,
                          JobSeekerPhone = jobseeker.Phone,
                          JobSeekerImage = jobseeker.ProfileImagePath,
                          JobSeekerResume = jobseeker.ResumeFilePath
                      };
            return await res.ToListAsync();
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

        public async Task UpdateJobOpportunityAsync(CreateJobOpportunityDTO dto)
        {
            var entity = await _context.JobOpportunities.FirstOrDefaultAsync(x => x.Id == dto.Id);
            if (entity != null)
            {
                entity.Title = dto.Title;
                entity.Description = dto.Description;
                entity.Country = dto.Country;
                entity.City = dto.City;
                entity.Region = dto.Region;
                entity.Skills = dto.Skills;
                entity.Responsability = dto.Responsability;
                entity.JobPrivileges = dto.JobPrivileges;
                entity.JobLocation = dto.JobLocation;
                entity.OtherApplicationCondition = dto.OtherApplicationCondition;
                entity.Gender = dto.Gender;
                entity.IsMustHaveDrivingLicense = dto.IsMustHaveDrivingLicense;
                entity.MinAmountOfSkills = dto.MinAmountOfSkills;
                entity.ExperienceCount = dto.ExperienceCount;
                entity.MinGPA = dto.MinGPA;
                entity.EducationCertificationType = dto.EducationCertificationType;
                entity.JobLevel = dto.JobLevel;
                entity.JobType = dto.JobType;
                entity.JobApplicationStatus = dto.JobApplicationStatus;
                _context.Update(entity);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Experience Not Found");
            }
        }
    }
}
