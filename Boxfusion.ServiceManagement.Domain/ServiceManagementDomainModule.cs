using Abp.AspNetCore.Configuration;
using Abp.AutoMapper;
using Abp.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Boxfusion.ServiceManagement.Domain
{
    public class ServiceManagementDomainModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            var thisAssembly = Assembly.GetExecutingAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            //IocManager.IocContainer.Register(
            //  Component.For<ICustomPermissionChecker>().Forward<ITaxiMSPermissionChecker>().Forward<TaxiMSPermissionChecker>().ImplementedBy<TaxiMSPermissionChecker>().LifestyleTransient()
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
                typeof(ServiceManagementDomainModule).Assembly,
                moduleName: "Dep",
                useConventionalHttpVerbs: true);
        }
    }
}
