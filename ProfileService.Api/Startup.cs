using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProfileService.Business.Abstract;
using ProfileService.Data.Repository;
using ProfileService.Data.Repository.EntityFramework;
using ProfileService.Domain.Commands;
using ProfileService.Domain.Queries;
using Swashbuckle.AspNetCore.Swagger;
using Service = ProfileService.Business;

namespace ProfileService.Api
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
            services.AddAutoMapper(typeof(Startup));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<EFDbContext>(x =>
            {
                x.UseSqlServer(Configuration.GetConnectionString("MsSqlDb"), b => b.MigrationsAssembly("ProfileService.Api"));
            });

            services.AddSwaggerGen(
                x =>
                {
                    x.SwaggerDoc("v1",
                        new Info
                        {
                            Title = "ProfileService",
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

            services.AddTransient<IProfileService, Service.ProfileService>();
            services.AddTransient<IProfileTypeService, Service.ProfileTypeService>();
            services.AddTransient<IProfileRepository, ProfileRepository>();
            services.AddTransient<IProfileTypeRepository, ProfileTypeRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ProfileQueryHandlerFactory, ProfileQueryHandlerFactory>();
            services.AddScoped<ProfileTypeQueryHandlerFactory, ProfileTypeQueryHandlerFactory>();
            services.AddScoped<ProfileCommandHandlerFactory, ProfileCommandHandlerFactory>();
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
            app.UseSwaggerUI(x => { x.SwaggerEndpoint("/swagger/v1/swagger.json", "ProfileService"); });
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
