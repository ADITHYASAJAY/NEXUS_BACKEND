
using NexusBackEndAPI.Entities;
using NexusBackEndAPI.Repository;

namespace NexusBackEndAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<ContextClass>();
            builder.Services.AddTransient<ClassScheduleRepository>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //Cors
            builder.Services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options =>
                {
                    options.AllowAnyOrigin()    //allow any client url
                    .AllowAnyMethod() //allow any http method
                    .AllowAnyHeader(); //allow any header
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors("AllowOrigin");

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
