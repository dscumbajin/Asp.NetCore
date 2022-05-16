using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Servicio.api.Libreria.Core;
using Servicio.api.Libreria.Core.ContextMongoDB;
using Servicio.api.Libreria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servicio.api.Libreria
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

            services.Configure<MongoSettings>
                (Configuration.GetSection(nameof(MongoSettings)));

            services.AddSingleton<IMongoSettings>
                (d => d.GetRequiredService<IOptions<MongoSettings>>().Value);


            services.AddTransient<IAutorContext, AutorContext>();
            services.AddTransient<IAutorRepository, AutorRepository>();
            
            //Trabaja cada vez que un cliente haga un request y se destruye cuando termina
            services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Servicio.api.Libreria", Version = "v1" });
            });

            services.AddCors( opt => {
                opt.AddPolicy("CorsRules", rule =>
                {
                    rule.AllowAnyHeader().AllowAnyMethod().WithOrigins("*"); 
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Servicio.api.Libreria v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("CorsRules");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


        }
    }
}
