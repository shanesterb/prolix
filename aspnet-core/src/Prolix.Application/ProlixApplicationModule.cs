using System.Reflection;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Prolix.Authorization;
using Prolix.Authorization.Roles;
using Prolix.Authorization.Users;
using Prolix.MultiTenancy;
using Prolix.Roles.Dto;
using Prolix.Users.Dto;
using AutoMapper;

namespace Prolix
{
    [DependsOn(
        typeof(ProlixCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ProlixApplicationModule : AbpModule
    {

        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ProlixAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProlixApplicationModule).GetAssembly());

            // TODO: Is there somewhere else to store these, with the dto classes
            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Role and permission
                cfg.CreateMap<Permission, string>().ConvertUsing(r => r.Name);
                cfg.CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);    

                cfg.CreateMap<CreateRoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
                cfg.CreateMap<RoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());

                IRepository<Role, int> repository = IocManager.Resolve<IRepository<Role, int>>();
                // User and role
                cfg.CreateMap<UserRole, string>().ConvertUsing(  (r) =>  {
                    //TODO: Fix, this seems hacky
                    Role role = repository.FirstOrDefault(r.RoleId);
                    return role.DisplayName;
                });

                IocManager.Release(repository);
                
                cfg.CreateMap<UserDto, User>();
                cfg.CreateMap<UserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());

                cfg.CreateMap<CreateUserDto, User>();
                cfg.CreateMap<CreateUserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());
            });
        }
    }
}