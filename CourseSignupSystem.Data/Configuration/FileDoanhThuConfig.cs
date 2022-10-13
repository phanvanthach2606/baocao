using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CourseSignupSystem.Data.Configuration
{
    class FileDoanhThuConfig : IEntityTypeConfiguration<FileDoanhThu>
    {
        public void Configure(EntityTypeBuilder<FileDoanhThu> builder)
        {
            builder.ToTable("FileDoanhThu");

            builder.HasKey(x => x.MaHocVien);

            builder.Property(x => x.MaHocVien).UseIdentityColumn();
            builder.Property(x => x.HoTen).HasMaxLength(200).IsRequired();
            builder.Property(x => x.LopHoc).HasMaxLength(200).IsRequired();
            builder.Property(x => x.NgayHocTrongTuan).HasMaxLength(200).IsRequired();
            builder.Property(x => x.GioHoc);
            builder.Property(x => x.HocPhi);
            builder.Property(x => x.GiaoVien).HasMaxLength(200).IsRequired();

        }
    }
}
