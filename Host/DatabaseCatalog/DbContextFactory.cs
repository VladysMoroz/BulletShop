using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCatalog
{
    //public class DbContextFactory : IDesignTimeDbContextFactory<CatalogDbContext>
    //{
    //    CatalogDbContext IDesignTimeDbContextFactory<CatalogDbContext>.CreateDbContext(string[] args)
    //    {
    //        var projectPath = Directory.GetCurrentDirectory();
    //        var configurationPath = Path.Combine(projectPath, @"..\BulletShop");


    //        IConfigurationRoot configuration = new ConfigurationBuilder()
    //           .SetBasePath(configurationPath)
    //           .AddJsonFile("appsettings.json")
    //           .Build();

    //        var builder = new DbContextOptionsBuilder<CatalogDbContext>();
    //        var connectionString = configuration.GetConnectionString("DefaultConnection");
    //        builder.UseSqlServer(connectionString);

    //        return new CatalogDbContext(builder.Options);
    //    }
    //}
}
