using Microsoft.EntityFrameworkCore;
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
using Traning_Platfrom_Core.Entity.Client;
using Traning_Platfrom_Core.Entity.Organization;
using Traning_Platfrom_Core.Helper;
using Traning_Platfrom_Core.IRepositaries;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Traning_Platfrom_Core.Enums.Enums;

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
            var profile = await _context.JobSeekers.FirstOrDefaultAsync(x => x.Id == dto.JobSeekerId);
            if (profile != null)
            {
                profile.ProfileBio = dto.ProfileBio;
                profile.ProfileImagePath = dto.ProfileImagePath;
                profile.ResumeFilePath = dto.ResumeFilePath;
                profile.Address = dto.Address;
                profile.IsHaveDrivingLicense = dto.IsHaveDrivingLicense;
                _context.Update(profile);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("JobSeeker Not Found");
            }
        }

        public async Task CreateEducationHistoryAsync(EducationHistoryDTO dto)
        {
            var profile = await _context.JobSeekers.FirstOrDefaultAsync(x => x.Id == dto.JobSeekerId);
            if (profile != null)
            {
                EducationHistory educationHistory = new EducationHistory()
                {
                    Title = dto.Title,
                    Specification = dto.Specification,
                    OrganizationName = dto.OrganizationName,
                    StartDate = dto.StartDate,
                    EndDate = dto.EndDate,
                    Description = dto.Description,
                    GPA = dto.GPA,
                    GPAInPercentage = ServiceHelper.CalaucluateAVG(dto.GPA, dto.GradingSystem),
                    GradingSystem = dto.GradingSystem,
                    EducationCertificationType = dto.EducationCertificationType,
                    JobSeeker = profile
                };
                await _context.AddAsync(educationHistory);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("JobSeeker Not Found");
            }
        }

        public async Task CreateExperienceAsync(ExperienceDTO dto)
        {
            var profile = await _context.JobSeekers.FirstOrDefaultAsync(x => x.Id == dto.JobSeekerId);
            if (profile != null)
            {
                var jobField = await _context.JobFields.FirstOrDefaultAsync(x => x.Id == dto.JobFieldId);
                if (jobField != null)
                {
                    Experience experience = new Experience()
                    {
                        JobTitle = dto.JobTitle,
                        StartDate = dto.StartDate,
                        EndDate = dto.EndDate,
                        Description = dto.Description,
                        CompanyName = dto.CompanyName,
                        JobLevel = dto.JobLevel,
                        JobType = dto.JobType,
                        JobSeeker = profile,
                        JobField = jobField
                    };
                }
                else
                {
                    throw new Exception("JobSeeker Not Found");
                }

            }
            else
            {
                throw new Exception("Job Field Not Found");
            }
        }

        public async Task CreateJobSeekerSkillAsync(CreateJobSeekerSkill dto)
        {
            var profile = await _context.JobSeekers.FirstOrDefaultAsync(x => x.Id == dto.JobSeekerId);
            if (profile != null)
            {
                var skill = await _context.Skills.FirstOrDefaultAsync(x => x.Id == dto.SkillId);
                if (skill != null)
                {
                    JobSeekerSkill jobSeekerSkill = new JobSeekerSkill()
                    {
                        JobSeeker = profile,
                        Skill = skill
                    };
                }
                else
                {
                    throw new Exception("Skill Not Found");
                }
            }
            else
            {
                throw new Exception("JobSeeker Not Found");
            }
        }

        public async Task DeleteEducationHistoryAsync(int Id)
        {
            var entity = await _context.EducationHistories.FirstOrDefaultAsync(x => x.Id == Id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                _context.Update(entity);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Education History Not Found");
            }
        }

        public async Task DeleteExperienceAsync(int Id)
        {
            var entity = await _context.Experiences.FirstOrDefaultAsync(x => x.Id == Id);
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

        public async Task DeleteJobSeekerSkillAsync(int Id)
        {
            var entity = await _context.JobSeekerSkills.FirstOrDefaultAsync(x => x.Id == Id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                _context.Update(entity);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("JobSeekerSkill Not Found");
            }
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
            var profile = await _context.JobSeekers.FirstOrDefaultAsync(x => x.Id == dto.JobSeekerId);
            if (profile != null)
            {
                var entity = await _context.JobOpportunities.FirstOrDefaultAsync(x => x.Id == dto.JonOpportunityId);
                if (entity != null)
                {
                    JobApplication jobApplication = new JobApplication()
                    {
                        Note = dto.Note,
                        JobSeeker = profile,
                        JobOpportunity = entity,
                    };
                }
                else
                {
                    throw new Exception("Job Application Not Found");
                }

            }
            else
            {
                throw new Exception("JobSeeker Not Found");
            }
        }

        public async Task UpdateEducationHistoryAsync(EducationHistoryDTO dto)
        {
            var entity = await _context.EducationHistories.FirstOrDefaultAsync(x => x.Id == dto.Id);
            if (entity != null)
            {
                entity.Title = dto.Title;
                entity.Specification = dto.Specification;
                entity.OrganizationName = dto.OrganizationName;
                entity.StartDate = dto.StartDate;
                entity.EndDate = dto.EndDate;
                entity.Description = dto.Description;
                entity.GPA = dto.GPA;
                entity.GPAInPercentage = ServiceHelper.CalaucluateAVG(dto.GPA, dto.GradingSystem);
                entity.GradingSystem = dto.GradingSystem;
                entity.EducationCertificationType = dto.EducationCertificationType;
                _context.Update(entity);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Education History Not Found");
            }
        }

        public async Task UpdateExperienceAsync(ExperienceDTO dto)
        {
            var entity = await _context.Experiences.FirstOrDefaultAsync(x => x.Id == dto.Id);
            if (entity != null)
            {
                entity.JobTitle = dto.JobTitle;
                entity.StartDate = dto.StartDate;
                entity.EndDate = dto.EndDate;
                entity.Description = dto.Description;
                entity.CompanyName = dto.CompanyName;
                entity.JobLevel = dto.JobLevel;
                entity.JobType = dto.JobType;
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
