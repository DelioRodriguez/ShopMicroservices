using Microsoft.EntityFrameworkCore;
using ShopMicroservices.Categories.Domain.Interfaces;
using ShopMicroservices.Categories.Persistance.Context;
using ShopMicroservices.Categories.Persistance.Respositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var connstring = builder.Configuration.GetConnectionString("ShopContext");

builder.Services.AddDbContext<ShopContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ShopContext")));

builder.Services.AddScoped<ICategoriesRepository, CategoryRepository>();

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
