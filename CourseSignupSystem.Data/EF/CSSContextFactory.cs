using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CourseSignupSystem.Data.EF
{
    public class CSSContextFactory : IDesignTimeDbContextFactory<CSSDbContext>
    {
        public CSSDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("Phan_mem_ghi_danh");

            var optionsBuilder = new DbContextOptionsBuilder<CSSDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new CSSDbContext(optionsBuilder.Options);
        }
    }
}
