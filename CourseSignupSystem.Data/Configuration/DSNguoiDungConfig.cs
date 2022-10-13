using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignupSystem.Data.Configuration
{
    public class DSNguoiDungConfig : IEntityTypeConfiguration<DSNguoiDung>
    {
        public void Configure(EntityTypeBuilder<DSNguoiDung> builder)
        {
            builder.ToTable("DSNguoiDung");

            builder.HasKey(x => x.TenNguoiDung);

            builder.Property(x => x.TenNguoiDung).UseIdentityColumn();
            builder.Property(x => x.Email).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Role).HasMaxLength(200).IsRequired();

        }
    }
}
