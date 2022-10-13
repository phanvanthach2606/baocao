using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CourseSignupSystem.Data.Configuration
{
    class DSHocVienConfig : IEntityTypeConfiguration<DSHocVien>
    {
        public void Configure(EntityTypeBuilder<DSHocVien> builder)
        {
            builder.ToTable("DSHocVien");

            builder.HasKey(x => x.id);

            builder.Property(x => x.MaHV).UseIdentityColumn().IsRequired();

            builder.Property(x => x.HinhAnh).HasMaxLength(200).IsRequired();

            builder.Property(x => x.HoTen).HasMaxLength(200).IsRequired();

            builder.Property(x => x.PhuHuynh).HasMaxLength(200).IsRequired();

            builder.Property(x => x.DiaChi).HasMaxLength(200).IsRequired();

            builder.Property(x => x.NgaySinh);

            builder.Property(x => x.SDT).HasMaxLength(200).IsRequired();

            builder.Property(x => x.Email).HasMaxLength(200).IsRequired();
        }
    }
}
