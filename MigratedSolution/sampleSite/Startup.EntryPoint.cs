
namespace WebSite
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;
    using System.Collections.Generic;

    public partial class Startup
    {  
        public static readonly Dictionary<string, string> _switchMappings =
        new Dictionary<string, string>
        {
            { "--reportService", "reportService"}
        };

        private static IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Entry point of windows form application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Start(string[] args)
        {
            sampleSite.Program.Main(args);
        }

        /// <summary>
        /// Entry Point of the web Application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        /// <summary>
        /// Returns a new WebHost
        /// </summary>
        /// <param name="args">run arguments</param>
        /// <returns>a new WebHost</returns>
        public static IWebHost BuildWebHost(string[] args){
            var config = new ConfigurationBuilder()
                .AddCommandLine(args, _switchMappings)
                .Build();
            return WebHost.CreateDefaultBuilder(args)
                //// logging
                //.ConfigureLogging(builder => builder.AddFile(options =>
                //{
                //    options.FileName = "log-";
                //    options.LogDirectory = "LogFiles";
                //    options.FileSizeLimit = 20 * 1024 * 1024;
                //}))
                //// IIS Deployment
                //.UseUrls("http://localhost:81")
                //.UseIISIntegration()
                .UseConfiguration(config)
                .UseStartup<Startup>()
                .Build();
        }
    }
}
