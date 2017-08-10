using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Prolix.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Prolix.Web.Host.Startup
{
    [DependsOn(
       typeof(ProlixWebCoreModule))]
    public class ProlixWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ProlixWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProlixWebHostModule).GetAssembly());
        }
    }
}
