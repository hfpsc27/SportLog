using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SportLog.API.Data;
using SportLog.API.Interfaces;
using SportLog.API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SportLogAppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SportLogDbContext") ?? throw new InvalidOperationException("Connection string 'SportLogDbContext' not found.")));

builder.Services.AddScoped<ISportRepository, SportRepository>();
// Add services to the container.

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
