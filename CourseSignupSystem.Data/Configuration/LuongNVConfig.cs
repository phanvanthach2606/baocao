using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignupSystem.Data.Configuration
{
    public class LuongNVConfig : IEntityTypeConfiguration<LuongNV>
    {
        public void Configure(EntityTypeBuilder<LuongNV> builder)
        {
            builder.ToTable("LuongNhanVien");

            builder.HasKey(x => x.MaGiaoVien);

            builder.Property(x => x.MaGiaoVien).UseIdentityColumn();
            builder.Property(x => x.TenGiangVien).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(200).IsRequired();
            builder.Property(x => x.SDT).IsRequired();
            builder.Property(x => x.TongLuong);
            builder.Property(x => x.TrangThai).HasMaxLength(200).IsRequired();

        }
    }
}
