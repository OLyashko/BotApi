using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BotApi.Services;
using Serilog;
using BotApi.Interfaces;

namespace BotApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            /* Log.Logger = new LoggerConfiguration()
                     .ReadFrom.Configuration(configuration).
                     CreateLogger();
             or: services.AddSingleton<Serilog.ILogger>(logger);        */

            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddTransient<IMessageSender, MessageSender>();
            services.AddMvc();//.SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
                   c.SwaggerDoc("v1",
                       new Swashbuckle.AspNetCore.Swagger.Info
                       {
                           Title = Configuration.GetSection("ServiceInfo:Name").Value, //serviceInfo?.ServiceName,
                           Version = Configuration.GetSection("ServiceInfo:Version").Value,//serviceInfo.ServiceVersion,
                           Description = Configuration.GetSection("ServiceInfo:Description").Value
                       }));

            Log.Warning("teeest worning0");

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //loggerFactory.AddSerilog();

            Log.Warning("teeest worning1");

          

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });


            app.UseHttpsRedirection();
            app.UseMvc();
            //app.UseMiddleware<MessageMiddleware>();

            //throw new Exception("Test exception 123");
        }
    }
}
