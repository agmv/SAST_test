using Microsoft.Extensions.Hosting;
using OutSystems.Application.Initialization.ASPNetCore;

namespace ssSystem_ {
    public class Program : ProgramBase<Startup> {
        public static void Main(string[] args) {
            RealMain(args);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => RealCreateHostBuilder(args);
    }
}
