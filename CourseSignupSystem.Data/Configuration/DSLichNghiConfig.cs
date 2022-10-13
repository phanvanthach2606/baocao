using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignupSystem.Data.Configuration
{
    public class DSLichNghiConfig : IEntityTypeConfiguration<DSLichNghi>
    {
        public void Configure(EntityTypeBuilder<DSLichNghi> builder)
        {
            builder.ToTable("DSLichNghir");

            builder.HasKey(x => x.TenNgayNghi);

            builder.Property(x => x.TenNgayNghi).UseIdentityColumn();
            builder.Property(x => x.LyDo).HasMaxLength(200).IsRequired();
            builder.Property(x => x.ThoiGianBatDau);
            builder.Property(x => x.ThoiGianKetThucd);
        }
    }
}
