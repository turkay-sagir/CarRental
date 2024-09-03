using CarRental.DAL.Context;
using CarRental.DAL.Entities;
using CarRental.Patterns.CQRS.Handlers.BrandHandlers;
using CarRental.Patterns.CQRS.Handlers.LocationHandlers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using NuGet.Protocol;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<CarContext>();

#region BrandHandlers
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();
builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
#endregion

#region LocationHandlers
builder.Services.AddScoped<CreateLocationCommandHandler>();
builder.Services.AddScoped<UpdateLocationCommandHandler>();
builder.Services.AddScoped<RemoveLocationCommandHandler>();
builder.Services.AddScoped<GetLocationQueryHandler>();
builder.Services.AddScoped<GetLocationByIdQueryHandler>();
#endregion

builder.Services.AddMediatR(cfg=>cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<CarContext>();

builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
    options.AccessDeniedPath = "/ErrorPages/Error401";
    options.LoginPath = "/Login/Index";

});

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
