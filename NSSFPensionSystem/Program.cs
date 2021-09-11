using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NSSFPensionSystem.Setting;
using NSSFPensionSystem.Services;
using NSSFPensionSystem.Services.Impl;

namespace NSSFPensionSystem
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri(APIEndpoint.BaseUrl),
                Timeout = new TimeSpan(0, 0, 500)
            });

            builder.Services.AddScoped<ApiService>();
            builder.Services.AddScoped<UserService>();
            builder.Services.AddScoped<IConstantValueService, ConstantValueService>();

            await builder.Build().RunAsync();
        }
    }
}
