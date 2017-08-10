using Abp.Zero.EntityFrameworkCore;
using Prolix.Authorization.Roles;
using Prolix.Authorization.Users;
using Prolix.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace Prolix.EntityFrameworkCore
{
    public class ProlixDbContext : AbpZeroDbContext<Tenant, Role, User, ProlixDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public ProlixDbContext(DbContextOptions<ProlixDbContext> options)
            : base(options)
        {

        }
    }
}
