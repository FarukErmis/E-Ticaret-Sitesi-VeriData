using AutoMapper;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Infrastructure.Helpers;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Polly;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IWebHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                             .SetBasePath(env.ContentRootPath)
                             .AddJsonFile("appsettings.json", reloadOnChange: true, optional: true)
                             .AddJsonFile($"appsettings.{env.EnvironmentName}.json", reloadOnChange: true, optional: true)
                             .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(Configuration);

            //Http Context'i Sürecimize ekliyoruz.
            services.AddHttpContextAccessor();


            services.AddSession(options =>
                    options.IdleTimeout = TimeSpan.FromSeconds(1800));



            //Register Refit Interfaces
            //Refit.HttpClientFactory
            RegisterClients(services);

            //Add AutoMapper
            //AutoMapper.Extensions.Microsoft.DependencyInjection
            services.AddAutoMapper(typeof(Startup));

            //MVC modülünü sürecimize ekliyoruz.
            services.AddControllersWithViews()
                //Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
                .AddRazorRuntimeCompilation();

            //Microsoft.AspNetCore.Authentication.Cookies
            //Asp.NEt Core MVC'de Oturum Yönetimini Core Identity ile gerçekleþtiriyoruz. Core Identity'de Cookie yönetimini kullanýyoruz.
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie(options =>
                    {
                        options.LoginPath = "/Account/Login";
                    });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Core Identity Servisimizi aktifleþtiriyoruz.
            app.UseAuthentication();

            app.UseSession();

            //wwwroot klasörüne riþim izni veriyoruz.
            app.UseStaticFiles();

            //Durum kodlarý ile ilgili sayfalarý kullanma izni veriyoruz...
            app.UseStatusCodePages();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapDefaultControllerRoute();
            });
        }

        private void RegisterClients(IServiceCollection services)
        {
            //RegisterHttpHandler
            services.AddScoped<AuthTokenHandler>();

            var baseUrl = Configuration
                .GetSection("Settings")
                .GetSection("Host")["CoreAPIServer"];
            var baseUri = new Uri(baseUrl);

            //Account
            services.AddRefitClient<IAccountApi>()
                .ConfigureHttpClient(client => { client.BaseAddress = baseUri; })
                .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60)))
                .AddTransientHttpErrorPolicy(p => p.RetryAsync(3));

            //Category
            services.AddRefitClient<ICategoryApi>()
               .ConfigureHttpClient(client => { client.BaseAddress = baseUri; })
               .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60)))
               .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
               .AddHttpMessageHandler((s) => s.GetService<AuthTokenHandler>());

            //Brand
            services.AddRefitClient<IBrandApi>()
               .ConfigureHttpClient(client => { client.BaseAddress = baseUri; })
               .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60)))
               .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
               .AddHttpMessageHandler((s) => s.GetService<AuthTokenHandler>());

            //CommentReaction
            services.AddRefitClient<ICommentReactionApi>()
               .ConfigureHttpClient(client => { client.BaseAddress = baseUri; })
               .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60)))
               .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
               .AddHttpMessageHandler((s) => s.GetService<AuthTokenHandler>());

            //Product
            services.AddRefitClient<IProductApi>()
               .ConfigureHttpClient(client => { client.BaseAddress = baseUri; })
               .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60)))
               .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
               .AddHttpMessageHandler((s) => s.GetService<AuthTokenHandler>());

            //ProductComment
            services.AddRefitClient<IProductCommentApi>()
               .ConfigureHttpClient(client => { client.BaseAddress = baseUri; })
               .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60)))
               .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
               .AddHttpMessageHandler((s) => s.GetService<AuthTokenHandler>());

            //ProductDetail
            services.AddRefitClient<IProductDetailApi>()
               .ConfigureHttpClient(client => { client.BaseAddress = baseUri; })
               .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60)))
               .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
               .AddHttpMessageHandler((s) => s.GetService<AuthTokenHandler>());

            //ProductImage
            services.AddRefitClient<IProductImageApi>()
               .ConfigureHttpClient(client => { client.BaseAddress = baseUri; })
               .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60)))
               .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
               .AddHttpMessageHandler((s) => s.GetService<AuthTokenHandler>());


            //ProductProperty
            services.AddRefitClient<IProductPropertyApi>()
               .ConfigureHttpClient(client => { client.BaseAddress = baseUri; })
               .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60)))
               .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
               .AddHttpMessageHandler((s) => s.GetService<AuthTokenHandler>());

            //ShippingSetting
            services.AddRefitClient<IShippingSettingApi>()
               .ConfigureHttpClient(client => { client.BaseAddress = baseUri; })
               .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60)))
               .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
               .AddHttpMessageHandler((s) => s.GetService<AuthTokenHandler>());

            //User
            services.AddRefitClient<IUserApi>()
               .ConfigureHttpClient(client => { client.BaseAddress = baseUri; })
               .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60)))
               .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
               .AddHttpMessageHandler((s) => s.GetService<AuthTokenHandler>());

            //UserDetail
            services.AddRefitClient<IUserDetailApi>()
               .ConfigureHttpClient(client => { client.BaseAddress = baseUri; })
               .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60)))
               .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
               .AddHttpMessageHandler((s) => s.GetService<AuthTokenHandler>());

            //UserDetail
            services.AddRefitClient<IBillingAddressApi>()
               .ConfigureHttpClient(client => { client.BaseAddress = baseUri; })
               .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60)))
               .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
               .AddHttpMessageHandler((s) => s.GetService<AuthTokenHandler>());

            //UserDetail
            services.AddRefitClient<IFavoriteProductApi>()
               .ConfigureHttpClient(client => { client.BaseAddress = baseUri; })
               .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60)))
               .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
               .AddHttpMessageHandler((s) => s.GetService<AuthTokenHandler>());

            //UserDetail
            services.AddRefitClient<IOrderApi>()
               .ConfigureHttpClient(client => { client.BaseAddress = baseUri; })
               .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60)))
               .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
               .AddHttpMessageHandler((s) => s.GetService<AuthTokenHandler>());

            //UserDetail
            services.AddRefitClient<IOrderInfoApi>()
               .ConfigureHttpClient(client => { client.BaseAddress = baseUri; })
               .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60)))
               .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
               .AddHttpMessageHandler((s) => s.GetService<AuthTokenHandler>());

            //UserDetail
            services.AddRefitClient<IShipmentInfoApi>()
               .ConfigureHttpClient(client => { client.BaseAddress = baseUri; })
               .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60)))
               .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
               .AddHttpMessageHandler((s) => s.GetService<AuthTokenHandler>());

            //UserDetail
            services.AddRefitClient<IShippingAddressApi>()
               .ConfigureHttpClient(client => { client.BaseAddress = baseUri; })
               .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60)))
               .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
               .AddHttpMessageHandler((s) => s.GetService<AuthTokenHandler>());
        }
    }
}
