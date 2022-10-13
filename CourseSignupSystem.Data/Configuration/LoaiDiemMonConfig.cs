using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignupSystem.Data.Configuration
{
    public class LoaiDiemMonConfig : IEntityTypeConfiguration<LoaiDiemMon>
    {
        public void Configure(EntityTypeBuilder<LoaiDiemMon> builder)
        {
            builder.ToTable("LoaiDiemMon");

            builder.HasKey(x => x.TenKhaoDaoTao);

            builder.Property(x => x.TenMonHoc).HasMaxLength(200).IsRequired();
            builder.Property(x => x.LoaiDiem).HasMaxLength(200).IsRequired();
            builder.Property(x => x.SoCotDiem).IsRequired();
            builder.Property(x => x.SoCotDiemBatBuoc).IsRequired();

        }
    }
}
