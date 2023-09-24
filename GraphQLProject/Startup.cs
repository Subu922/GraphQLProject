using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Mutation;
using GraphQLProject.Query;
using GraphQLProject.Schema;
using GraphQLProject.Services;
using GraphQLProject.Type;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GraphQLProject
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
            services.AddControllers();

            services.AddTransient<IMenuRepository, MenuRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IReservationRepository, ReservationRepository>();
            services.AddTransient<MenuType>();
            services.AddTransient<MenuQuery>();
            services.AddTransient<ISchema, RootSchema>();

            services.AddTransient<MenuInputType>();
            services.AddTransient<CategoryInputType>();
            services.AddTransient<ReservationInputType>();

            services.AddTransient<MenuMutation>();
            services.AddTransient<CategoryMutation>();
            services.AddTransient<ReservationMutation>();
            services.AddTransient<RootMutation>();

            services.AddTransient<CategoryType>();
            services.AddTransient<CategoryQuery>();
            services.AddTransient<ReservationType>();
            services.AddTransient<ReservationQuery>();
            services.AddTransient<RootQuery>();

            services.AddGraphQL(b => b.AddAutoSchema<ISchema>().AddSystemTextJson());
            services.AddDbContext<GraphQLDbContext>(option => option.UseSqlServer(Configuration.GetConnectionString("GraphQLDbContextConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseGraphiQl("/graphql");
            app.UseGraphQL<ISchema>();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
