using Abp.Application.Services;
using Intent.RoslynWeaver.Attributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Collections.Generic;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Web.Startup.Swagger.AbpAppServiceApiVersionSpecification", Version = "1.0")]

namespace Boxfusion.Dep.Web.Host.Swagger
{
    public class AbpAppServiceApiVersionSpecification : IApiControllerSpecification
    {
        public bool IsSatisfiedBy(ControllerModel controller)
        {
            var typeInfo = controller.ControllerType;
            var type = controller.ControllerType.AsType();
            if (!typeof(IApplicationService).IsAssignableFrom(type) ||
               !typeInfo.IsPublic || typeInfo.IsAbstract || typeInfo.IsGenericType)
            {
                return false;
            }
            if (!(controller.Attributes is List<object> attributes))
            {
                return false;
            }
            if (typeInfo.IsDefined(typeof(ApiVersionAttribute), false))
            {
                attributes.Add(new ApiVersionAttribute("1"));//Set default version
            }
            return true;
        }
    }
}