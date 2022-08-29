using Abp.AspNetCore.Configuration;
using Abp.AutoMapper;
using Abp.Modules;
using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Boxfusion.ContentManagement.Domain
{
    public class ContentManagementDomainModule : AbpModule
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
                typeof(ContentManagementDomainModule).Assembly,
                moduleName: "TaxiMS",
                useConventionalHttpVerbs: true);
        }
    }
}
