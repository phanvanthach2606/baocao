using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignupSystem.Data.Configuration
{
    public class DSLopHocConfig : IEntityTypeConfiguration<DSLopHoc>
    {
        public void Configure(EntityTypeBuilder<DSLopHoc> builder)
        {
            builder.ToTable("DSLopHoc");

            builder.HasKey(x => x.TenLop);

            builder.Property(x => x.TenLop).UseIdentityColumn();
            builder.Property(x => x.MoTa).HasMaxLength(200).IsRequired();

        }
    }
}
