using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignupSystem.Data.Configuration
{
    class ThongTinSVConfig : IEntityTypeConfiguration<ThongTinSV>
    {
        public void Configure(EntityTypeBuilder<ThongTinSV> builder)
        {
            builder.ToTable("ThongTinSV");

            builder.HasKey(x => x.MaLop);

            builder.Property(x => x.MaLop).UseIdentityColumn();
            builder.Property(x => x.KhoaDaoTao).HasMaxLength(200).IsRequired();
            builder.Property(x => x.GiaTien);
            builder.Property(x => x.KhoaDaoTao).HasMaxLength(200).IsRequired();
            builder.Property(x => x.TrangThai).HasMaxLength(200).IsRequired();
            builder.Property(x => x.MaHV).HasMaxLength(200).IsRequired();
            builder.Property(x => x.HoTen).HasMaxLength(200).IsRequired();
            builder.Property(x => x.NgaySinh).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(200).IsRequired();
        }
    }
}
