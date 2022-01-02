using AutoMapper;
using CommercialSite.API.Infrastructor.Models.Base;
using CommercialSite.Common.Service.WorkContext;
using CommercialSite.Model.Context;
using CommercialSite.Service.Repository.BillingAddress;
using CommercialSite.Service.Repository.Brand;
using CommercialSite.Service.Repository.Category;
using CommercialSite.Service.Repository.CommentReaction;
using CommercialSite.Service.Repository.FavoriteProduct;
using CommercialSite.Service.Repository.Order;
using CommercialSite.Service.Repository.OrderInfo;
using CommercialSite.Service.Repository.Product;
using CommercialSite.Service.Repository.ProductComment;
using CommercialSite.Service.Repository.ProductDetail;
using CommercialSite.Service.Repository.ProductImage;
using CommercialSite.Service.Repository.ProductProperty;
using CommercialSite.Service.Repository.ShipmentInfo;
using CommercialSite.Service.Repository.ShippingAddress;
using CommercialSite.Service.Repository.ShippingSetting;
using CommercialSite.Service.Repository.User;
using CommercialSite.Service.Repository.UserDetail;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.API
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


            //API modülünü sürecimize ekliyoruz.
            services.AddControllers();

            //Add-Migration Init
            //Update-database
            //DataContext dosyasýna gönderilecek olan Postgre SQL connection string yapýmýzý oluþturuyoruz...
            services.AddDbContext<DataContext>(option =>
            {
                option.UseNpgsql(Configuration["ConnectionStrings:Conn"]);
            });

            //Net Core yapýsý tamamiyle Dependency Injection yapýsýyla çalýþtýðýndan Interface ile Service ve Repository classlarýnýn baðýmlýlýðýný tanýmlýyoruz.
            services.AddTransient<IWorkContext, ApiWorkContext>(); 
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IBrandRepository, BrandRepository>();
            services.AddTransient<ICommentReactionRepository, CommentReactionRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProductCommentRepository, ProductCommentRepository>();
            services.AddTransient<IProductDetailRepository, ProductDetailRepository>();
            services.AddTransient<IProductImageRepository, ProductImageRepository>();
            services.AddTransient<IProductPropertyRepository, ProductPropertyRepository>();
            services.AddTransient<IShippingSettingRepository, ShippingSettingRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserDetailRepository, UserDetailRepository>();
            services.AddTransient<IBillingAddressRepository, BillingAddressRepository>();
            services.AddTransient<IFavoriteProductRepository, FavoriteProductRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IOrderInfoRepository, OrderInfoRepository>();
            services.AddTransient<IShipmentInfoRepository, ShipmentInfoRepository>();
            services.AddTransient<IShippingAddressRepository, ShippingAddressRepository>();


            //Add AutoMapper
            //AutoMapper.Extensions.Microsoft.DependencyInjection
            services.AddAutoMapper(typeof(Startup));

            //JWT Auth
            //Microsoft.AspNetCore.Authentication.JwtBearer
            services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(option =>
                {
                    option.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = Configuration["Tokens:Issuer"],
                        ValidAudience = Configuration["Tokens:Audience"],
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Tokens:Key"]))
                    };
                });

            //Swagger
            //Swashbuckle.AspNetCore.Swagger
            //Swashbuckle.AspNetCore.SwaggerGen
            //Swashbuckle.AspNetCore.SwaggerUI
            //Swagger
            //Swashbuckle.AspNetCore.Swagger
            //Swashbuckle.AspNetCore.SwaggerGen
            //Swashbuckle.AspNetCore.SwaggerUI
            services.AddSwaggerGen(c =>
            {
                //using Microsoft.OpenApi.Models
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Swagger on ASP.Net Core",
                    Version = "1.0.0.",
                    Description = "Bilge Adam Backend Servis Projesi(ASP.NET Core 3.1)",
                    TermsOfService = new System.Uri("http://swagger.io/terms")
                });

                c.AddSecurityDefinition("Bearer",
                    new OpenApiSecurityScheme
                    {
                        Description = "Bilge Adam Core API Projesi JWT Authorization header (Bearer) kullanmaktadýr. Örnek: \"Authorization: Bearer {token} \"",
                        Type = SecuritySchemeType.Http,
                        Scheme = "bearer"
                    });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme {
                            Reference = new OpenApiReference {
                                Id = "Bearer",
                                Type = ReferenceType.SecurityScheme
                            }
                        }, new List<string>()
                    }
                });
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("../swagger/v1/swagger.json", "MY API V1");
                    c.RoutePrefix = "swagger";
                });
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
