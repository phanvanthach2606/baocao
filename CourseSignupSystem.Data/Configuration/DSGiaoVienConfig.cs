using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignupSystem.Data.Configuration
{
    public class DSGiaoVienConfig : IEntityTypeConfiguration<DSGiaoVien>
    {
        public void Configure(EntityTypeBuilder<DSGiaoVien> builder)
        {
            builder.ToTable("DSGiaoVien");

            builder.HasKey(x => x.id);

            builder.Property(x => x.AnhDaiDien).HasMaxLength(200).IsRequired();
            builder.Property(x => x.HoTen).HasMaxLength(200).IsRequired();
            builder.Property(x => x.GioiTinh).HasMaxLength(200).IsRequired();
            builder.Property(x => x.DiaChi).HasMaxLength(200).IsRequired();
            builder.Property(x => x.DT).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(200).IsRequired();
        }
    }
}
