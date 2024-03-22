using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Entity.Lookups;

namespace Traning_Platfrom_Core.EntityConfigurations
{
    internal class JobFieldEntityTypeConfiguration : IEntityTypeConfiguration<JobField>
    {
        public void Configure(EntityTypeBuilder<JobField> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
                       builder.Property(x => x.CreationDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.LastModifiedDate).IsRequired(false);
        }
    }
}
