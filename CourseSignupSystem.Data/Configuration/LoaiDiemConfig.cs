using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignupSystem.Data.Configuration
{
    class LoaiDiemConfig : IEntityTypeConfiguration<LoaiDiem>
    {
        public void Configure(EntityTypeBuilder<LoaiDiem> builder)
        {
            builder.ToTable("LoaiDiem");

            builder.HasKey(x => x.MaLoaiDiem);

            builder.Property(x => x.MaLoaiDiem).UseIdentityColumn();
            builder.Property(x => x.TenLoaiDiem).HasMaxLength(200).IsRequired();
            builder.Property(x => x.HeSo).IsRequired();
        }
    }
}
