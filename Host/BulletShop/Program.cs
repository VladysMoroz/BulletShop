using ApplicationServices.Services;
using Core.AutoMapper;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using DatabaseCatalog;
using DatabaseCatalog.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(FromWeaponToWeaponProductViewModelMapper));

// --- Services ---

builder.Services.AddScoped<IWeaponService, WeaponService>();

// --- Interfaces ---

builder.Services.AddScoped<IWeaponRepository, WeaponRepository>();

// ------------------

builder.Services.AddDbContext<CatalogDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

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
