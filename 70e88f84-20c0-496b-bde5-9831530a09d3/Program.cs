using Microsoft.Extensions.Hosting;
using OutSystems.Application.Initialization.ASPNetCore;

namespace ssRuntimeDestroyerLib {
    public class Program : ProgramBase<Startup> {
        public static void Main(string[] args) {
            RealMain(args);
        }
    }
}
