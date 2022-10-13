using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignupSystem.Data.Configuration
{
    class DSKhoaConfig : IEntityTypeConfiguration<DSKhoa>
    {
        public void Configure(EntityTypeBuilder<DSKhoa> builder)
        {
            builder.ToTable("DSKhoa");

            builder.HasKey(x => x.MaKhoa);

            builder.Property(x => x.MaKhoa).UseIdentityColumn();
            builder.Property(x => x.TenKhoa).HasMaxLength(200).IsRequired();
        }
    }
}
