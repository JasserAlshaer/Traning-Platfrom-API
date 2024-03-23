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
using Traning_Platfrom_Core.Dtos.JobOpportunity;
using Traning_Platfrom_Core.Dtos.JobSeeker;
using Traning_Platfrom_Core.Dtos.JobSeeker.Profile;
using Traning_Platfrom_Core.Dtos.JobSeeker.Resume;
using Traning_Platfrom_Core.Dtos.Skills;
using Traning_Platfrom_Core.Entity.Client;
using Traning_Platfrom_Core.Entity.Company;
using Traning_Platfrom_Core.Entity.Lookups;
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
                    GPAInPercentage = ServiceHelper.CalculateAVG(dto.GPA, (GradingSystem)Enum.Parse(typeof(GradingSystem), dto.GradingSystem)),
                    GradingSystem = (GradingSystem)Enum.Parse(typeof(GradingSystem), dto.GradingSystem),
                    EducationCertificationType = (EducationCertificationType)Enum.Parse(typeof(EducationCertificationType), dto.EducationCertificationType),
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
                        EndDate = dto.EndDate == default(DateTime) ? null : dto.EndDate,
                        Description = dto.Description,
                        CompanyName = dto.CompanyName,
                        JobLevel = (JobLevel)Enum.Parse(typeof(JobLevel), dto.JobLevel),
                        JobType = (JobType)Enum.Parse(typeof(JobType), dto.JobType),
                        JobSeeker = profile,
                        JobField = jobField
                    };
                    await _context.AddAsync(experience);
                    await _context.SaveChangesAsync();
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
                    await _context.AddAsync(jobSeekerSkill);
                    await _context.SaveChangesAsync();
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

        public async Task<JobSeekerCompleteProfileDTO> GetJobSeekerCompleteProfileAsync(int Id)
        {
            var res = from jobseeker in _context.JobSeekers
                      where jobseeker.Id == Id
                      select new JobSeekerCompleteProfileDTO
                      {
                          JobSeekerId = jobseeker.Id,
                          FullName =$"{jobseeker.FirstName} {jobseeker.SecondName} {jobseeker.LastName}",
                          Email = jobseeker.EmailAddress,
                          Phone = jobseeker.Phone,
                          Pio = jobseeker.ProfileBio,
                          FaceBook = jobseeker.FaceBook,
                          Github = jobseeker.Github,
                          LinkedIn = jobseeker.LinkedIn,
                          Instgram = jobseeker.Instgram,
                          Country = jobseeker.Country,
                          City = jobseeker.City,
                          Major = jobseeker.Major,
                          Lanaguage = jobseeker.Lanaguage,
                          Nationality = jobseeker.Nationality,
                          MaritalStatus = jobseeker.MaritalStatus.ToString(),
                          DateofBirth = jobseeker.BirthDate,
                          FullAddress = jobseeker.Address,
                          Gender = jobseeker.Gender.ToString(),
                          Image = jobseeker.ProfileImagePath,
                          ResumePath=jobseeker.ResumeFilePath,
                          Qualification=jobseeker.Qualification.ToString(),

                      };
            var obj = await res.SingleOrDefaultAsync();
            if(obj != null)
            {
                obj.Experiences = await GetJobSeekerExperiencesByIdAsync(Id);
                int sum = 0;
                foreach (var ex in obj.Experiences)
                {
                    sum += ServiceHelper.CalculateDaysDifference(ex.StartDate, ex.EndDate);
                }
                obj.ExperienceInDays = sum;
                obj.Educations = await GetJobSeekerEducationHistoryByIdAsync(Id);
            }
            return obj;
            
        }

        public async Task<List<EducationHistoryDTO>> GetJobSeekerEducationHistoryByIdAsync(int Id)
        {
            var res = from edu in _context.EducationHistories
                      where edu.IsDeleted == false
                      && edu.JobSeeker.Id == Id
                      orderby edu.StartDate descending
                      select new EducationHistoryDTO
                      {
                          Id = edu.Id,
                          Title = edu.Title,
                          Specification = edu.Specification,
                          OrganizationName = edu.OrganizationName,
                          StartDate = edu.StartDate,
                          EndDate = edu.EndDate,
                          Description = edu.Description,
                          GPA = edu.GPA,
                          GradingSystem = edu.GradingSystem.ToString(),
                          EducationCertificationType = edu.EducationCertificationType.ToString(),
                          JobSeekerId = Id
                      };
            return await res.ToListAsync();
        }

        public async Task<List<ExperienceDTO>> GetJobSeekerExperiencesByIdAsync(int Id)
        {
            var res = from exp in _context.Experiences
                      join field in _context.JobFields
                      on exp.JobField.Id equals field.Id
                      where exp.IsDeleted == false
                      && exp.JobSeeker.Id == Id
                      orderby exp.StartDate descending
                      select new ExperienceDTO
                      {
                          Id = exp.Id,
                          JobTitle = exp.JobTitle,
                          StartDate = exp.StartDate,
                          EndDate = exp.EndDate !=null?(DateTime)exp.EndDate:null,
                          Description = exp.Description,
                          CompanyName = exp.CompanyName,
                          JobLevel = exp.JobLevel.ToString(),
                          JobType = exp.JobType.ToString(),
                          JobFieldName = field.Title,
                          JobFieldId = field.Id,
                          JobSeekerId = Id,
                      };
            return await res.ToListAsync();
        }

        public async Task<ProfileDTO> GetJobSeekerProfileByIdAsync(int Id)
        {
            var res = from jobseeker in _context.JobSeekers
                      where jobseeker.Id == Id
                      select new ProfileDTO
                      {
                          JobSeekerId = jobseeker.Id,
                          FirstName = jobseeker.FirstName,
                          SecondName = jobseeker.SecondName,
                          LastName = jobseeker.LastName,
                          Email = jobseeker.EmailAddress,
                          Phone = jobseeker.Phone,
                          Pio = jobseeker.ProfileBio,
                          FaceBook = jobseeker.FaceBook,
                          Github = jobseeker.Github,
                          LinkedIn = jobseeker.LinkedIn,
                          Instgram = jobseeker.Instgram,
                          Country = jobseeker.Country,
                          City = jobseeker.City,
                          Address = jobseeker.Address,
                          Major = jobseeker.Major,
                          Lanaguage = jobseeker.Lanaguage.ToString(),
                          Image=jobseeker.ProfileImagePath,
                          ResumeFilePath=jobseeker.ResumeFilePath,
                      };
            return await res.SingleAsync();
        }

        public async Task<ResumeDTO> GetJobSeekerResumeByIdAsync(int Id)
        {
            var res = from jobseeker in _context.JobSeekers
                      where jobseeker.Id == Id
                      select new ResumeDTO
                      {
                          JobSeekerId = jobseeker.Id,
                          FirstName = jobseeker.FirstName,
                          SecondName = jobseeker.SecondName,
                          LastName = jobseeker.LastName,
                          Email = jobseeker.EmailAddress,
                          Phone = jobseeker.Phone,
                          Nationality = jobseeker.Nationality,
                          MaritalStatus = jobseeker.MaritalStatus.ToString(),
                          DateofBirth = jobseeker.BirthDate,
                          FullAddress = jobseeker.Address,
                          Gender = jobseeker.Gender.ToString(),
                          Qualification = jobseeker.Qualification.ToString(),
                      };
            return await res.SingleAsync();
        }
        public async Task<List<JobOpportunityCardDTO>> GetMyJobApplicationAsync(int Id)
        {
            var res = from job in _context.JobOpportunities
                      join org in _context.Organizations
                      on job.Organization.Id equals org.Id
                      join application in _context.JobApplications
                      on job.Id equals application.JobOpportunity.Id
                      join jobseeker in _context.JobSeekers
                      on application.JobSeeker.Id equals jobseeker.Id
                      where job.IsDeleted == false && jobseeker.Id == Id
                      && application.IsDeleted == false
                      orderby job.CreationDate descending
                      select new JobOpportunityCardDTO
                      {
                          Id = job.Id,
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
                          AppliedDate = application.CreationDate
                      };
            var obj = await res.ToListAsync();
            if(obj != null)
            {
                foreach( var item in obj)
                {
                    var interview = await _context.JobInterviews.FirstOrDefaultAsync(x => x.Opportunity.Id == item.Id);
                    if (interview != null)
                    {
                        item.InterviewId= interview.Id;
                        item.IsThereInterview = true;
                    }
                    else
                    {
                        item.IsThereInterview = false;
                    }
                }
            }
            return obj;
        }
        public async Task<JobInterviewDTO> GetMyInterviewByIdAsync(int Id)
        {
            var res = from meeting in _context.JobInterviews
                      where meeting.Id == Id
                      select new JobInterviewDTO
                      {
                          Id = Id,
                          Title=meeting.Title,
                          InterviewType=meeting.InterviewType.ToString(),
                          Note=meeting.Note,
                          StartDate = meeting.StartDate,
                          EndDate = meeting.EndDate
                      };
            return await res.SingleOrDefaultAsync();
        }
        public async Task SendJobApplicationAsync(CreateJobApplicationDTO dto)
        {
            var profile = await _context.JobSeekers.FirstOrDefaultAsync(x => x.Id == dto.JobSeekerId);
            if (profile != null)
            {
                var entity = await _context.JobOpportunities.FirstOrDefaultAsync(x => x.Id == dto.JobOpportunityId);
                if (entity != null)
                {
                    JobApplication jobApplication = new JobApplication()
                    {
                        Note = "",//dto.Note,
                        JobSeeker = profile,
                        JobOpportunity = entity,
                    };
                    await _context.JobApplications.AddAsync(jobApplication);
                    await _context.SaveChangesAsync();
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
        public async Task<string> CheckIfPreAppliedByJobIdAndJobSeekerIdAsync(int jobId, int jobSeekerId)
        {
            var application = await _context.JobApplications.FirstOrDefaultAsync(x => x.JobSeeker.Id == jobSeekerId && x.JobOpportunity.Id == jobId);
            if (application != null)
            {
                return "No";
            }
            else
            {
                return "YES";
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
                entity.GPAInPercentage = ServiceHelper.CalculateAVG(dto.GPA, (GradingSystem)Enum.Parse(typeof(GradingSystem), dto.GradingSystem));
                entity.GradingSystem = (GradingSystem)Enum.Parse(typeof(GradingSystem), dto.GradingSystem);
                entity.EducationCertificationType = (EducationCertificationType)Enum.Parse(typeof(EducationCertificationType), dto.EducationCertificationType);
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
                entity.JobLevel = (JobLevel)Enum.Parse(typeof(JobLevel), dto.JobLevel);
                entity.JobType = (JobType)Enum.Parse(typeof(JobType), dto.JobType);
                _context.Update(entity);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Experience Not Found");
            }
        }

        public async Task UpdateJobSeekerContactInfoAsync(ContactDTO dto)
        {
            var profile = await _context.JobSeekers.FirstOrDefaultAsync(x => x.Id == dto.JobSeekerId);
            if (profile != null)
            {
                profile.Country = dto.Country;
                profile.City = dto.City;
                profile.Address = dto.Address;
                _context.Update(profile);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("JobSeeker Not Found");
            }
        }
        public async Task UpdateJobSeekerMainInfoAsync(MainInfoDTO dto)
        {
            var profile = await _context.JobSeekers.FirstOrDefaultAsync(x => x.Id == dto.JobSeekerId);
            if (profile != null)
            {
                profile.FirstName = dto.FirstName;
                profile.SecondName = dto.SecondName;
                profile.LastName = dto.LastName;
                profile.EmailAddress = dto.Email;
                profile.Phone = dto.Phone;
                profile.Major = dto.Major;
                profile.Lanaguage = dto.Lanaguage;
                profile.ProfileBio = dto.Pio;
                _context.Update(profile);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("JobSeeker Not Found");
            }
        }

        public async Task UpdateJobSeekerProfileImageAsync(ProfileImageDTO dto)
        {
            var profile = await _context.JobSeekers.FirstOrDefaultAsync(x => x.Id == dto.JobSeekerId);
            if (profile != null)
            {
                profile.ProfileImagePath = dto.Image;
                _context.Update(profile);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("JobSeeker Not Found");
            }
        }
        public async Task UpdateJobSeekerProfileResumeFileAsync(ProfileResumeDTO dto)
        {
            var profile = await _context.JobSeekers.FirstOrDefaultAsync(x => x.Id == dto.JobSeekerId);
            if (profile != null)
            {
                profile.ResumeFilePath = dto.File;
                _context.Update(profile);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("JobSeeker Not Found");
            }
        }
        public async Task UpdateJobSeekerResumeInfoAsync(ResumeDTO dto)
        {
            var profile = await _context.JobSeekers.FirstOrDefaultAsync(x => x.Id == dto.JobSeekerId);
            if (profile != null)
            {
                profile.FirstName = dto.FirstName;
                profile.SecondName = dto.SecondName;
                profile.LastName = dto.LastName;
                profile.Phone = dto.Phone;
                profile.EmailAddress = dto.Email;
                profile.BirthDate = dto.DateofBirth;
                profile.Gender = (Gender)Enum.Parse(typeof(Gender), dto.Gender);
                profile.MaritalStatus = (MaritalStatus)Enum.Parse(typeof(MaritalStatus), dto.MaritalStatus);
                profile.Nationality = dto.Nationality;
                profile.Qualification = (EducationCertificationType)Enum.Parse(typeof(EducationCertificationType), dto.Qualification);
                _context.Update(profile);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("JobSeeker Not Found");
            }
        }


        public async Task UpdateJobSeekerSocialInfoAsync(SocialMediaDTO dto)
        {
            var profile = await _context.JobSeekers.FirstOrDefaultAsync(x => x.Id == dto.JobSeekerId);
            if (profile != null)
            {
                profile.FaceBook = dto.FaceBook;
                profile.Instgram = dto.Instgram;
                profile.LinkedIn = dto.LinkedIn;
                profile.Github = dto.Github;
                _context.Update(profile);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("JobSeeker Not Found");
            }
        }
    }
}
