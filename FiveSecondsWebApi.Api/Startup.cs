using FiveSecondsWebApi.Domain.Repositories;
using FiveSecondsWebApi.Infrastructure.Mappers;
using FiveSecondsWebApi.Infrastructure.Repositories;
using FiveSecondsWebApi.Infrastructure.Services.Abstract;
using FiveSecondsWebApi.Infrastructure.Services.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FiveSecondsWebApi.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(AutoMapperConfig.Initialize());
            services.AddScoped<IQuestionsRepostiory, QuestionsRepository>();
            services.AddScoped<IQuestionsService, QuestionsService>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
