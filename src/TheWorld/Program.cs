using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace TheWorld
{
    public class Program
    {
        // This is where our application is starting up
        public static void Main(string[] args)
        {
            // build a WebHost which starts listening for requests
            var host = new WebHostBuilder()
                .UseKestrel() // web server name
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration() // IIS support
                .UseStartup<Startup>() // use class "Startup" (Startup.cs) to set up web server
                .Build();

            // start listening for requests
            host.Run();
        }
    }
}
