using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FirstUse.Configuration;

namespace FirstUse.Web.Host.Startup
{
    [DependsOn(
       typeof(FirstUseWebCoreModule))]
    public class FirstUseWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FirstUseWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FirstUseWebHostModule).GetAssembly());
        }
    }
}
