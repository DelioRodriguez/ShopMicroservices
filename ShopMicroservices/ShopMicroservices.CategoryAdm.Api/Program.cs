using Microsoft.EntityFrameworkCore;
using ShopMicroservices.Categories.IOC.Dependencies;
using ShopMicroservices.Categories.Persistance.Context;

var builder = WebApplication.CreateBuilder(args);





// Add services to the container.

builder.Services.AddDbContext<ShopContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("ShopContext")));

//Agregar las dependencias del modulo de cursos//
builder.Services.AddCategoryDependency();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
