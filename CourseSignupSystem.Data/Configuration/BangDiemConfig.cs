using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignupSystem.Data.Configuration
{
    public class BangDiemConfig : IEntityTypeConfiguration<BangDiem>
    {
        public void Configure(EntityTypeBuilder<BangDiem> builder)
        {
            builder.ToTable("BangDiem");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.Ten).HasMaxLength(200).IsRequired();
            builder.Property(x => x.KiemTraMieng).HasMaxLength(200).IsRequired();
            builder.Property(x => x.DiemTrungBinh).HasMaxLength(200).IsRequired();

        }
    }
}
