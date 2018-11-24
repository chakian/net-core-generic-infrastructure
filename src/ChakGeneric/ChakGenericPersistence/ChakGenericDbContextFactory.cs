using ChakGenericPersistence.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChakGenericPersistence
{
    public class ChakGenericDbContextFactory : DesignTimeDbContextFactoryBase<ChakGenericDbContext>
    {
        public ChakGenericDbContextFactory(
            string connectionStringName = "connectionString", 
            string aspNetCoreEnvironment = "ASPNETCORE_ENVIRONMENT", 
            string webProjectName = "ChakGeneric.SampleWebUI") 
            : base(connectionStringName, aspNetCoreEnvironment, webProjectName)
        {
        }

        protected override ChakGenericDbContext CreateNewInstance(DbContextOptions<ChakGenericDbContext> options)
        {
            return new ChakGenericDbContext(options);
        }
    }
}
