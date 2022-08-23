using BenimProjem.Areas.Admin.Helpers;
using BenimProjem.Business.Helpers;
using BenimProjem.Business.Services;
using BenimProjem.DataAccess.Abstract;
using BenimProjem.DataAccess.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BenimProjem
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
            // request att�m response d�nd� 1 tane nesne �retir. baska newleme olmaz Addscoped'de. webe at�lan her istekte onu kullan�r.
            // singleton sadece 1 tane �retir.
            services.AddControllersWithViews();
            services.AddScoped<ICookieHelper, CookieHelper>();
            services.AddScoped<IStringHelper, StringHelper>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserDal, UserDal>();

            services.AddScoped<IUserTicketService, UserTicketService>();
            services.AddScoped<IUserTicketDal, UserTicketDal>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryDal, CategoryDal>();

            services.AddScoped<ISliderService, SliderService>();
            services.AddScoped<ISliderDal, SliderDal>();

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductDal, ProductDal>();

            services.AddScoped<IProductImageService, ProductImageService>();
            services.AddScoped<IProductImageDal, ProductImageDal>();

            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderDal, OrderDal>();

            services.AddSingleton<ICacheManager, CacheManager>(); // singleton = herkes eri�ebilecek
            services.AddSingleton<IMemoryCache, MemoryCache>();
            services.AddScoped<IAdminChecker, AdminChecker>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                /*
                 ?id=1 demek queryString ile urlden data almak. a.com/urun.aspx?id=1
                 en alttaki s uyumlu di�erleri de�il. biz altakini yuapt�k 
                 a.com/urun?name=elma
                 a.com/urun/elma 
                 */
                endpoints.MapControllerRoute(name: "login", pattern: "/giris", defaults: new { controller = "Home", action = "Login" });


                endpoints.MapControllerRoute(name: "urun", pattern: "/urun/{name}", defaults: new { controller = "Product", action = "Index" });

                endpoints.MapControllerRoute(name: "basket", pattern: "/basket", defaults: new { controller = "Basket", action = "AddBasket" });

                //�r�n ekledi�imizde kayd�rmal� basket
                endpoints.MapControllerRoute(name: "basket-products", pattern: "/basket-products", defaults: new { controller = "Basket", action = "GetProductBasket" });


                endpoints.MapControllerRoute(name: "getbasket", pattern: "/get-basket", defaults: new { controller = "Basket", action = "GetBasket" });


                //basket
                endpoints.MapControllerRoute(name: "basketdetail", pattern: "/mybasket", defaults: new { controller = "Basket", action = "Index" });
                //basket

                //Order
                endpoints.MapControllerRoute(name: "order", pattern: "/order", defaults: new { controller = "Checkout", action = "Index" });
                //order

                //Shop
                endpoints.MapControllerRoute(name: "shop", pattern: "/category/{name}/{page?}", defaults: new { controller = "Shop", action = "Index" });
                //shop

                // admin/home/index
                endpoints.MapControllerRoute(
                    name: "AdminArea",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                //mdv projelerinde default url yap�s�
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
