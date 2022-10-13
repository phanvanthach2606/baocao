using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignupSystem.Data.Configuration
{
    public class DangNhapConfig : IEntityTypeConfiguration<dangnhap>
    {
        public void Configure(EntityTypeBuilder<dangnhap> builder)
        {
            builder.ToTable("dangnhap");
            builder.Property(x => x.username).IsRequired().HasMaxLength(200);
            builder.Property(x => x.passwork).IsRequired().HasMaxLength(200);
            builder.Property(x => x.email).IsRequired().HasMaxLength(200);
            builder.Property(x => x.userid).IsRequired().HasMaxLength(200);
        }
    }
}
