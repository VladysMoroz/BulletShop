using ApplicationServices.Services;
using Core.AutoMapper.AmmunitionMappers;
using Core.AutoMapper.BulletMappers;
using Core.AutoMapper.ColdWeaponMapper;
using Core.AutoMapper.OpticMappers;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using DatabaseCatalog;
using DatabaseCatalog.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// SERVICES

builder.Services.AddScoped<IWeaponService, WeaponService>();
builder.Services.AddScoped<IColdWeaponService, ColdWeaponService>();
builder.Services.AddScoped<IOpticService, OpticService>();
builder.Services.AddScoped<IBulletService, BulletService>();
builder.Services.AddScoped<IAmmunitionService, AmmunitionService>();

// --------

// REPOSITORIES

builder.Services.AddScoped<IWeaponRepository, WeaponRepository>();
builder.Services.AddScoped<IColdWeaponRepository, ColdWeaponRepository>();
builder.Services.AddScoped<IOpticRepository, OpticRepository>();
builder.Services.AddScoped<IBulletRepository, BulletRepository>();
builder.Services.AddScoped<IAmmunitionRepository, AmmunitionRepository>();

// ---------

builder.Services.AddAutoMapper(
     typeof(FromAmmunitionToAmmunitionViewModelMapper)
    ,typeof(FromColdWeaponToColdWeaponViewModelMapper)
    ,typeof(FromOpticToOpticViewModelMapper)
    ,typeof(FromBulletToBulletViewModelMapper));
//builder.Services.AddAutoMapper(typeof());

//builder.Services.AddScoped<IMyPasswordHasher, MyPasswordHasher>();

builder.Services.AddDbContext<CatalogDbContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
});


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();


app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
