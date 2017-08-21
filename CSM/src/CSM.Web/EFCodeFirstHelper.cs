using CSM.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSM.Web
{
    public class TemporaryDbContextFactory : IDbContextFactory<InstanceEntities>
    {
        public InstanceEntities Create(DbContextFactoryOptions options)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(options.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{options.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            
            var configuration = builder.Build();
            var optionBuilder = new DbContextOptionsBuilder<InstanceEntities>();
            optionBuilder.UseSqlServer(configuration.GetConnectionString("CSMDBConnection"),
                b => b.MigrationsAssembly("CSM.Web")
                );
            return new InstanceEntities(optionBuilder.Options);
        }
    }
}
