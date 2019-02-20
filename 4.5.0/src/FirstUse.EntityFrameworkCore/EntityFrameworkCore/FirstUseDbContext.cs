using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FirstUse.Authorization.Roles;
using FirstUse.Authorization.Users;
using FirstUse.MultiTenancy;

namespace FirstUse.EntityFrameworkCore
{
    public class FirstUseDbContext : AbpZeroDbContext<Tenant, Role, User, FirstUseDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FirstUseDbContext(DbContextOptions<FirstUseDbContext> options)
            : base(options)
        {
        }
    }
}
