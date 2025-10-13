using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OutSystems.Application.Initialization.ASPNetCore;
using OutSystems.Application.Timers;

namespace ssRuntimeDestroyerLib {
    public class Startup : StartupBaseApp {
        public Startup(IConfiguration configuration) : base(configuration, AppUtils.Instance, AppUtils.StaticProperties.Instance, Assembly.GetExecutingAssembly()) {
        }

        public override IServiceCollection ConfigureApplicationServices(IServiceCollection services) {
            ConfigureTimers(services);
             

            return services;
        }

        private IServiceCollection ConfigureTimers(IServiceCollection services) {
                        services.AddSingleton<ITimerService>(new TimerService(new Dictionary<string, ITimerExecutor>()));
            return services;
        }
    }
}