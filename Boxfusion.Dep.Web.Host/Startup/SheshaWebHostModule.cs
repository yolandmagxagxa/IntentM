using Abp.Hangfire;
using Abp.Hangfire.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Boxfusion.Dep.Web.Core;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Web.Startup.Startup.SheshaWebHostModule", Version = "1.0")]

namespace Boxfusion.Dep.Web.Host.Startup
{
    [DependsOn(typeof(DepWebCoreModule),
        typeof(AbpHangfireAspNetCoreModule))]
    public class SheshaWebHostModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SheshaWebHostModule).GetAssembly());
        }
        public override void PreInitialize()
        {
            Configuration.BackgroundJobs.UseHangfire();
        }
    }
}