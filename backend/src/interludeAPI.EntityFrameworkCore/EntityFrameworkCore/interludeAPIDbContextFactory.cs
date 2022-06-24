using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace interludeAPI.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class interludeAPIDbContextFactory : IDesignTimeDbContextFactory<interludeAPIDbContext>
{
    public interludeAPIDbContext CreateDbContext(string[] args)
    {
        interludeAPIEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<interludeAPIDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new interludeAPIDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../interludeAPI.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
