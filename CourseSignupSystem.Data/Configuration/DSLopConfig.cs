using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignupSystem.Data.Configuration
{
    public class DSLopConfig : IEntityTypeConfiguration<DSLop>
    {
        public void Configure(EntityTypeBuilder<DSLop> builder)
        {
            builder.ToTable("DSLop");

            builder.HasKey(x => x.MaLop);

            builder.Property(x => x.MaLop).UseIdentityColumn();
            builder.Property(x => x.TenLop).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Khoa_khoi).HasMaxLength(200).IsRequired();
            builder.Property(x => x.SoLuongHocVien).HasMaxLength(200).IsRequired();

            builder.Property(x => x.TrangThai).HasMaxLength(200).IsRequired();

            builder.Property(x => x.HocPhi);
        }
    }
}
