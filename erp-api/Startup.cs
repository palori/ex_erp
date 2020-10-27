using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Microsoft.EntityFrameworkCore;
using erp_api.Contexts;
using erp_api.Repositories;
using erp_api.Data.DummyData;

namespace erp_api
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
            services.AddCors(); // Uncomment if in development

            services.AddControllers();

            services.AddDbContext<ErpContext>(options =>
                options.UseMySQL(Configuration.GetConnectionString("DefaultConnection")));

            #region repositories
            services.AddScoped<AddressesRepository>();
            services.AddScoped<ClientsRepository>();
            services.AddScoped<ComponentsRepository>();
            services.AddScoped<ItemInfosRepository>();
            services.AddScoped<OrderItemsRepository>();
            services.AddScoped<OrdersRepository>();
            services.AddScoped<ProcessesRepository>();
            services.AddScoped<ProcessInfosRepository>();
            services.AddScoped<SuppliersRepository>();
            services.AddScoped<TeamMembersRepository>();
            services.AddScoped<TradingInfosRepository>();
            services.AddScoped<WarehousesRepository>();
            #endregion
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

            if (env.IsDevelopment())
            {
                // Or uncomment if in development
                app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            }

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            if (env.IsDevelopment())
            {
                DummyData.Test(); // If DB does not exist -> create and adding some test data
            }
        }
    }
}