using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Entity.Client;

namespace Traning_Platfrom_Core.EntityConfigurations
{
    internal class JobSeekerEntityTypeConfiguration : IEntityTypeConfiguration<JobSeeker>
    {
        public void Configure(EntityTypeBuilder<JobSeeker> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CreationDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.LastModifiedDate).IsRequired(false);
            builder.Property(x => x.ProfileBio).IsRequired(false);
            builder.Property(x => x.ProfileImagePath).IsRequired(false);
            builder.Property(x => x.Address).IsRequired(false);
            builder.Property(x => x.ResumeFilePath).IsRequired(false);
            builder.Property(x => x.IsHaveDrivingLicense).IsRequired(false);
        }
    }
}
