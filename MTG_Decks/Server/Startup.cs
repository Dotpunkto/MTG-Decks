using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MTG_Decks.Server.DataAccess;
using Microsoft.EntityFrameworkCore;
using Quartz;
using System.Collections.Specialized;
using Quartz.Impl;
using MTG_Decks.Server.Job;
using MTG_Decks.Server.IRepositories;
using MTG_Decks.Server.Repositories;

namespace MTG_Decks.Server
{
	public class Startup
    {

        private IConfiguration Configuration { get; }
        private IScheduler _quartzScheduler;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _quartzScheduler = ConfigureQuartz();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();
            services.AddRazorPages();
			services.AddDbContext<MTG_Context>(options =>
                options.UseSqlite(Configuration.GetConnectionString("MTG_Context")));

            services.AddSingleton(provider => _quartzScheduler);
            services.AddScoped<ICardRepository, CardRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }

        public void OnShutDown()
        {
			if (!_quartzScheduler.IsShutdown)
            {
                _quartzScheduler.Shutdown();
            }
		}

        public IScheduler ConfigureQuartz()
        {
            NameValueCollection props = new NameValueCollection
            {
                { "quartz.serializer.type", "binary" }
            };
            StdSchedulerFactory factory = new StdSchedulerFactory(props);
			IScheduler sheduler = factory.GetScheduler().Result;
            sheduler.Start().Wait();
            CreateTaskandTrigger(sheduler);
            return sheduler;
		}

        private async void CreateTaskandTrigger(IScheduler sheduler)
        {
            IJobDetail jobtest = JobBuilder.Create<BulkDataJob>()
                .WithIdentity("BulkData")
                .Build();
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("triggerBulkData")
                .StartNow()
                .WithCronSchedule("0 0/1 * 1/1 * ? *")  // "0 0 0 1 1/1 ? *" : une fois par mois 
                .Build();
            await sheduler.ScheduleJob(jobtest, trigger);
        }
    }
}
