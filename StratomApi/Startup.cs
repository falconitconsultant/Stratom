using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationServices;
using ApplicationServices.Business.AppServices;
using ApplicationServices.Business.AppServices.IAppServices;
using ApplicationServices.Business.Services;
using ApplicationServices.Business.Services.IServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Persistance;
using Stratom.Form.Services.Services;

namespace StratomApi
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
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddTransient<IFicheService, FicheService>();
            services.AddTransient<IActiviteService, ActiviteService>();
            services.AddTransient<IActiviteTypeService, ActiviteTypeService>();
            services.AddTransient<IAssuranceDommageService, AssuranceDommageService>();
            services.AddTransient<IAssurancePersonneService, AssurancePersonneService>();
            services.AddTransient<IConcerneService, ConcerneService>();
            services.AddTransient<IContratsPortefeuilleService, ContratsPortefeuilleService>();
            services.AddTransient<IDescriptionActiviteService, DescriptionActiviteService>();
            services.AddTransient<IFicheClientProspectService, FicheClientProspectService>();
            services.AddTransient<IFicheContexteSimplifieeService, FicheContexteSimplifieeService>();
            services.AddTransient<IFicheFinService, FicheFinService>();
            services.AddTransient<IPhaseService, PhaseService>();
            services.AddDbContext<StratomContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default"), x => x.MigrationsAssembly("Stratom.Form.Data")));
            services.AddControllers();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Stratom Form", Version = "v1" });
            });
            //services.AddControllers();
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddTransient<IFicheRepository, FicheRepository>();
            //services.AddTransient<IActiviteRepository, ActiviteRepository>();
            //services.AddTransient<IActiviteTypeRepository, ActiviteTypeRepository>();
            //services.AddTransient<IAssuranceDommageRepository, AssuranceDommageRepository>();
            //services.AddTransient<IAssurancePersonneRepository, AssurancePersonneRepository>();
            //services.AddTransient<IConcerneRepository, ConcerneRepository>();
            //services.AddTransient<IContratsPortefeuilleRepository, ContratsPortefeuilleRepository>();
            //services.AddTransient<IDescriptionActiviteRepository, DescriptionActiviteRepository>();
            //services.AddTransient<IFicheClientProspectRepository, FicheClientProspectRepository>();
            //services.AddTransient<IFicheContexteSimplifieeRepository, FicheContexteSimplifieeRepository>();
            //services.AddTransient<IFicheFinRepository, FicheFinRepository>();
            //services.AddTransient<IPhaseRepository, PhaseRepository>();
            //services.AddDbContext<StratomContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default"), x => x.MigrationsAssembly("Stratom.Form.Data")));
            //services.AddControllers();
            //services.AddSwaggerGen(options =>
            //{
            //    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Stratom Form", Version = "v1" });
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Stratom Form V1");
            });
        }
    }
}
