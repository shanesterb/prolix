using Microsoft.EntityFrameworkCore;

namespace Prolix.EntityFrameworkCore
{
    public static class ProlixDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ProlixDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}