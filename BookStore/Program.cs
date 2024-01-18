using BookStore.DL.Interfaces;
using BookStore.DL.Repositories;
using BookStore.BL.Interfaces;
using BookStore.BL.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using BookStore.HealthChecks;

namespace BookStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<IBookRepository, BookRepository>();
            builder.Services.AddSingleton<IBookService, BookService>();
            builder.Services.AddSingleton<IAuthorRepository, AuthorRepository>();
            builder.Services.AddSingleton<IAuthorService, AuthorService>();
            builder.Services.AddSingleton<ILibraryService, LibraryService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddFluentValidationAutoValidation();
            builder.Services.AddValidatorsFromAssemblyContaining(typeof(Program));

            builder.Services.AddHealthChecks()
            .AddCheck<CustomHealthCheck>(nameof(CustomHealthCheck));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapHealthChecks("/healthz");

            app.MapControllers();

            app.Run();
        }
    }
}