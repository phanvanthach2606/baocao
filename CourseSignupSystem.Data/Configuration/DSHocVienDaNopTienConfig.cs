using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignupSystem.Data.Configuration
{
    class DSHocVienDaNopTienConfig : IEntityTypeConfiguration<DSHocVienDaNopTienPhi>
    {
        public void Configure(EntityTypeBuilder<DSHocVienDaNopTienPhi> builder)
        {
            builder.ToTable("DSHocVienDaNopTienPhi");

            builder.HasKey(x => x.MaHocVien);

            builder.Property(x => x.MaHocVien).UseIdentityColumn();
            builder.Property(x => x.HinhAnh).HasMaxLength(200).IsRequired();
            builder.Property(x => x.HoTen).HasMaxLength(200).IsRequired();
            builder.Property(x => x.PhuHuynh).HasMaxLength(200).IsRequired();
            builder.Property(x => x.DiaChi).HasMaxLength(200).IsRequired();
            builder.Property(x => x.NgaySinh);
            builder.Property(x => x.SDT).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(200).IsRequired();
            builder.Property(x => x.LopHoc).HasMaxLength(200).IsRequired();
        }
    }
}
