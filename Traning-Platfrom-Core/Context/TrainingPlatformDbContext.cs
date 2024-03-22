using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Entity.Client;
using Traning_Platfrom_Core.Entity.Lookups;
using Traning_Platfrom_Core.Entity.Company;
using Traning_Platfrom_Core.Entity.UserConfiguration;
using Traning_Platfrom_Core.EntityConfigurations;

namespace Traning_Platfrom_Core.Context
{
    public class TrainingPlatformDbContext : DbContext
    {
        public TrainingPlatformDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RoleEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserRolesEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new JobSeekerEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EducationHistoryEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ExperienceEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new JobSeekerSkillEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SkillEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new JobFieldEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrganizationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrganizationAdminEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new JobOpportunityEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new JobApplicationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new JobInterviewEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TestimonialEntityTypeConfiguration());
            
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<JobSeeker> JobSeekers { get; set; }
        public virtual DbSet<EducationHistory> EducationHistories { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<JobField> JobFields { get; set; }
        public virtual DbSet<JobSeekerSkill> JobSeekerSkills { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<OrganizationAdmin> OrganizationAdmins { get; set; }
        public virtual DbSet<JobOpportunity> JobOpportunities { get; set; }
        public virtual DbSet<JobApplication> JobApplications { get; set; }
        public virtual DbSet<JobInterview> JobInterviews { get; set; }
        public virtual DbSet<Testimonial> Testimonials { get; set; }
    }
}
