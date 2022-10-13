using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignupSystem.Data.Configuration
{
    public class DSMonHocConfig : IEntityTypeConfiguration<DSMonHoc>
    {
        public void Configure(EntityTypeBuilder<DSMonHoc> builder)
        {
            builder.ToTable("DSMonHoc");

            builder.HasKey(x => x.MaMonHoc);

            builder.Property(x => x.MaMonHoc).UseIdentityColumn();
            builder.Property(x => x.TenMonHoc).HasMaxLength(200).IsRequired();
            builder.Property(x => x.TenBoMon).HasMaxLength(200).IsRequired();
            builder.Property(x => x.TenKhoa).HasMaxLength(200).IsRequired();
        }
    }
}
