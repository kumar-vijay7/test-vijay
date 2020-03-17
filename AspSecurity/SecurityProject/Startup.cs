using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using SecurityProject.Repository;
using SecurityProject.Services;
using SecurityProject.Settings;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SecurityProject
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


            // services.AddSingleton(services.Configure<Connection>(Configuration.GetSection("Connection")));
            services.AddSingleton<ILoginRepository, LoginRepository>();
            services.AddSingleton<ILoginService, LoginService>();
            services.AddMvc();
            services.AddControllers();

            //configure object
            var JwtAppSetting = Configuration.GetSection("JwtSettings");
            services.Configure<JwtSettings>(JwtAppSetting);
            var jwtappsetting = JwtAppSetting.Get<JwtSettings>();
            var key = Encoding.ASCII.GetBytes(jwtappsetting.Key);

            //Authentication
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
              .AddJwtBearer(options =>
              {
                  options.TokenValidationParameters = new TokenValidationParameters
                  {
                      ValidateIssuer = true,
                      ValidateAudience = true,
                      ValidateLifetime = true,
                      ValidateIssuerSigningKey = true,
                      IssuerSigningKey = new SymmetricSecurityKey(key),
                      ValidIssuer = Configuration["JwtSettings:Issuer"],
                      ValidAudience = Configuration["JwtSettings:Issuer"]
                  };
              });
            services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
           // app.UseMvc();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
