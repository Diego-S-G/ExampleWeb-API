using ExampleWeb.Domain.Repositories;
using ExampleWeb.Domain.Services;
using ExampleWeb.Infrastructure.Repositories;
using ExampleWeb.Infrastructure.Services;
using ExampleWeb.Migrations.Data;
using Microsoft.EntityFrameworkCore;

namespace ExampleWeb.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IExampleRepository, ExampleRepository>();
            builder.Services.AddScoped<IExampleService, ExampleService>();
            

            builder.Services.AddDbContext<ExampleDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}