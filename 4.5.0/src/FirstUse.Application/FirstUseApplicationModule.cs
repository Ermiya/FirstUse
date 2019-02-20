using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FirstUse.Authorization;

namespace FirstUse
{
    [DependsOn(
        typeof(FirstUseCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FirstUseApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FirstUseAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FirstUseApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
