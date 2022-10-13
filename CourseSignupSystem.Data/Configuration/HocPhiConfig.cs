using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignupSystem.Data.Configuration
{
    public class HocPhiConfig : IEntityTypeConfiguration<HocPhi>
    {
        public void Configure(EntityTypeBuilder<HocPhi> builder)
        {
            builder.ToTable("HocPhi");

            builder.HasKey(x => x.LopHoc);

            builder.Property(x => x.ThuPhi);
            builder.Property(x => x.LoaiHocPhi);
            builder.Property(x => x.MucThuPhi);
            builder.Property(x => x.GhiChu).HasMaxLength(200).IsRequired();

        }
    }
}
