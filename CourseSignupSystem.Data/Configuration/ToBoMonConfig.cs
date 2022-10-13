using Microsoft.EntityFrameworkCore;
using CourseSignupSystem.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CourseSignupSystem.Data.Configuration
{
    public class ToBoMonConfig : IEntityTypeConfiguration<ToBoMon>
    {
        public void Configure(EntityTypeBuilder<ToBoMon> builder)
        {
            builder.ToTable("ToBoMon");

            builder.HasKey(x => x.TenToBoMon);

            builder.Property(x => x.TenToBoMon).UseIdentityColumn();
        }
    }
}
