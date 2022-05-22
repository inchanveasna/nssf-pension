using AKSoftware.WebApi.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NSSFPensionSystem.Services;
using NSSFPensionSystem.Services.Impl;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Blazor.AdminLte;
using NSSFPensionSystem.Shared.Components;

namespace NSSFPensionSystem
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            var BaseUrl = builder.Configuration.GetSection("BaseUrl").Value;
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(BaseUrl) });
            
            builder.Services.AddOidcAuthentication(options =>
            {
                // Configure your authentication provider options here.
                // For more information, see https://aka.ms/blazor-standalone-auth
                //builder.Configuration.Bind("local", options.ProviderOptions);
                builder.Configuration.Bind("oidc", options.ProviderOptions);

            });


            builder.Services.AddScoped<ApiService>();
            builder.Services.AddScoped<ServiceClient>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IConstantValueService, ConstantValueService>();
            builder.Services.AddScoped<IClaimService, ClaimService>();
            builder.Services.AddScoped<IAllowanceService, AllowanceService>();
            builder.Services.AddScoped<IPaymentService, PaymentService>();

            builder.Services.AddAdminLte();
            await builder.Build().RunAsync();
        }
    }
}
