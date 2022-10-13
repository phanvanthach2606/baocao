using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CourseSignupSystem.Data.Configuration
{
    class DSVaiTroConfig : IEntityTypeConfiguration<DSVaiTro>
    {
        public void Configure(EntityTypeBuilder<DSVaiTro> builder)
        {
            builder.ToTable("DSVaiTro");

            builder.HasKey(x => x.TenVaiTro);

            builder.Property(x => x.TenVaiTro).UseIdentityColumn();

        }
    }
}
