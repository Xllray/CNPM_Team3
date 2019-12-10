using ApplicationCore.Interfaces;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Web.Services;
using Microsoft.Extensions.Configuration;
using ApplicationCore.Services;
using System;


namespace Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            
            

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUserRepository,UserRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped< ProductListVmService>();
            services.AddScoped<UserVmService>();
            services.AddScoped<ProductService>();
            services.AddScoped<OrderService>();


            services.AddScoped<UserService>();
            



            services.AddDbContext<ProductContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Project_OnlineShopContext")));

            services.AddRazorPages();

            //cau hinh session
            services.AddMemoryCache();
            services.AddMvc();

            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(10);
            });

            

            
        }//

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

        }
    }
}