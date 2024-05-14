using ApplicationServices;
using ApplicationServices.Services;
using Core.AutoMapper;
using Core.Interfaces;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using DatabaseCatalog;
using DatabaseCatalog.Repositories;
using Host;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.Configure<JwtOptions>(configuration.GetSection(nameof(JwtOptions)));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IJwtProvider, JwtProvider>();

builder.Services.AddScoped<IUserService, UserService>();

//builder.Services.AddScoped<PasswordHasher>();

builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddAutoMapper(typeof(FromWeaponToWeaponProductViewModelMapper));

// --- Services ---

builder.Services.AddScoped<IWeaponService, WeaponService>();

builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<IMyPasswordHasher, MyPasswordHasher>();

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
app.UseRouting();


app.UseCookiePolicy(new CookiePolicyOptions
{
    MinimumSameSitePolicy = SameSiteMode.Strict,
    HttpOnly = Microsoft.AspNetCore.CookiePolicy.HttpOnlyPolicy.Always,
    Secure = CookieSecurePolicy.Always
});


app.UseAuthorization();
app.UseAuthentication();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    /*endpoints.MapUsersEndpoints();*/ // Your custom endpoints
});

app.Run();
