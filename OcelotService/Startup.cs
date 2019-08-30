using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Consul;

namespace OcelotService
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            //var builder = new ConfigurationBuilder()
            //    .SetBasePath(env.ContentRootPath)
            //    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true)
            //    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            //    .AddJsonFile("ocelot.json", optional: true, reloadOnChange: true)
            //    .AddEnvironmentVariables();

            //Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //var authenticationProviderKey = "OcelotKey";
            //var identityServerOptions = new IdentityServerOptions();
            //Configuration.Bind("IdentityServerOptions", identityServerOptions);

            //services.AddAuthentication(identityServerOptions.IdentityScheme)
            //    .AddIdentityServerAuthentication(authenticationProviderKey, options => {
            //        options.RequireHttpsMetadata = false; //是否启用https
            //        options.Authority = $"http://{identityServerOptions.ServerIP}:{identityServerOptions.ServerPort}";//配置授权认证的地址
            //        options.ApiName = identityServerOptions.ResourceName; //资源名称，跟认证服务中注册的资源列表名称中的apiResource一致
            //        options.SupportedTokens = SupportedTokens.Both;
            //    }
            //    );

            //services
            //    .AddOcelot(Configuration)
            //    .AddConsul()
            //    //.AddConfigStoredInConsul()
            //    ;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.UseOcelot().Wait();

            app.UseMvc();
        }
    }
}
