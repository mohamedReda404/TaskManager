

using Microsoft.EntityFrameworkCore;
using Task_Manager.Models;
using Task_Manager.Persistence;


namespace Task_Manager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.ApplicationServices();
            builder.Services.AddSwagger();
            builder.Services.AddIdentityApiEndpoints<ApplicationUser>().AddEntityFrameworkStores<AppDbContext>();
            builder.Services.AddDBConfig(builder.Configuration);
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapSwagger();
                app.UseSwaggerUI();
                app.MapScalarApiReference();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapIdentityApi<ApplicationUser>();
            app.MapControllers();

            app.Run();
        }
    }
}
