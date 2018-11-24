using ChakGenericPersistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace ChakGenericPersistence
{
    public class ChakGenericDbContext : DbContext
    {
        public ChakGenericDbContext(DbContextOptions<ChakGenericDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyAllConfigurations();
    }
}
