using Abp.AspNetCore.Configuration;
using Abp.AutoMapper;
using Abp.Modules;
using System.Reflection;

namespace Boxfusion.Dep.Domain
{
    public class DepDomainModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            var thisAssembly = Assembly.GetExecutingAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            //IocManager.IocContainer.Register(
            //  Component.For<ICustomPermissionChecker>().Forward<IDepPermissionChecker>().Forward<DepPermissionChecker>().ImplementedBy<DepPermissionChecker>().LifestyleTransient()
            //);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }

        /// inheritedDoc
        public override void PreInitialize()
        {
            base.PreInitialize();
        }

        /// inheritedDoc
        public override void PostInitialize()
        {
            Configuration.Modules.AbpAspNetCore().CreateControllersForAppServices(
                typeof(DepDomainModule).Assembly,
                moduleName: "Dep",
                useConventionalHttpVerbs: true);
        }
    }
}

