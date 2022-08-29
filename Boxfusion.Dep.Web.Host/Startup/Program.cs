using Intent.RoslynWeaver.Attributes;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Web.Startup.Startup.Program", Version = "1.0")]

namespace Boxfusion.Dep.Web.Host.Startup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .CaptureStartupErrors(true)
                .UseSetting("detailedErrors", "true")
                .UseStartup<Startup>()
                .Build();
        }

    }
}