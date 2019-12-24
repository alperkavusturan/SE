using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Text;
using TicketingService.Business.Abstract;
using TicketingService.Data.Repository;
using TicketingService.Data.Repository.EntityFramework;
using TicketingService.Domain.Commands;
using TicketingService.Domain.Queries;
using Service = TicketingService.Business;

namespace TicketingService.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var audConfig = Configuration.GetSection("Audience");
            var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(audConfig["Secret"]));
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = signingKey,
                ValidateIssuer = true,
                ValidIssuer = audConfig["Iss"],
                ValidateAudience = true,
                ValidAudience = audConfig["Aud"],
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero,
                RequireExpirationTime = true
            };

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = "JwtKey";
                options.DefaultChallengeScheme = "JwtKey";
            })
                .AddJwtBearer("JwtKey", x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.TokenValidationParameters = tokenValidationParameters;
                });

            services.AddAutoMapper(typeof(Startup));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<EfDbContext>(x =>
            {
                x.UseSqlServer(Configuration.GetConnectionString("MsSqlDb"), b => b.MigrationsAssembly("TicketingService.Api"));
            });

            services.AddSwaggerGen(
                x =>
                {
                    x.SwaggerDoc("v1",
                        new Info
                        {
                            Title = "TicketingService",
                            Version = "v1",
                            Description = "This is a microservice for ecosystem of the social app.",
                            Contact = new Contact
                            {
                                Email = "bilgi@alperkavusturan.com",
                                Name = "Alper Kavusturan",
                                Url = "alperkavusturan.com"
                            }
                        });
                });

            services.AddTransient<ITicketingService, Service.TicketingService>();
            services.AddTransient<ITicketingRepository, TicketingRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<TicketingQueryHandlerFactory, TicketingQueryHandlerFactory>();
            services.AddScoped<TicketingCommandHandlerFactory, TicketingCommandHandlerFactory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(x => { x.SwaggerEndpoint("/swagger/v1/swagger.json", "TicketingService"); });
            app.UseMvc();
        }
    }
}
