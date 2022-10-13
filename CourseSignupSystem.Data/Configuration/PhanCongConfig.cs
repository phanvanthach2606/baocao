using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignupSystem.Data.Configuration
{
    class PhanCongConfig : IEntityTypeConfiguration<PhanCong>
    {
        public void Configure(EntityTypeBuilder<PhanCong> builder)
        {
            builder.ToTable("PhanCong");

            builder.HasKey(x => x.MaGiaoVien);

            builder.Property(x => x.MaGiaoVien).UseIdentityColumn();
            builder.Property(x => x.TenGiangVien).HasMaxLength(200).IsRequired();
            builder.Property(x => x.MonHoc).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Lop).HasMaxLength(200).IsRequired();
            builder.Property(x => x.NgayBatDau);
            builder.Property(x => x.NgayKetThuc);
        }
    }
}
