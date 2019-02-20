using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FirstUse.EntityFrameworkCore
{
    public static class FirstUseDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FirstUseDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FirstUseDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
