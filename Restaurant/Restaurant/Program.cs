using AutoMapper;
using Business;
using Business.Interfaces;
using Business.Services;
using Business.Models;
using Data.Data;
using Data.Entities;
using Data.Interfaces;
using Data.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Restaurant;
using Business.Validation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


var connectionString = builder.Configuration.GetConnectionString("Restaurant");

var userDBconnectionString = builder.Configuration.GetConnectionString("UserDB");

builder.Services.AddDbContext<RestaurantDbContext>(x => x.UseSqlServer(connectionString));
builder.Services.AddDbContext<UserDbContext>(options => options.UseSqlServer(userDBconnectionString));


builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<UserDbContext>();



#region Authorization

AddAuthorizationPolicies();

#endregion



builder.Services.AddAutoMapper(typeof(AutomapperProfile));


builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();
builder.Services.AddMemoryCache();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(sp => SessionCart.GetCart(sp));
builder.Services.AddScoped(sp=>RestCart.GetCart(sp));

builder.Services.AddTransient<IIndentityService, IndentityService>();
builder.Services.AddTransient<IIngredientService, IngredientService>();
builder.Services.AddTransient<IDishCompositionService, DishCompositionService>();
builder.Services.AddTransient<IDishService, DishService>();
builder.Services.AddTransient<IRestaurantTableService, RestaurantTableService>();
builder.Services.AddTransient<IRestaurantTableRepository, RestaurantTableRepository>();
builder.Services.AddTransient<IOrderRepository, OrderRepository>();
builder.Services.AddTransient<IReservationRepository, ReservationRepository>();


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

app.UseSession();
app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");
app.UseRouting();

app.MapRazorPages(); // to solve /?area=Identity&page=2FAccount%2FRegister problem

app.UseAuthentication();
app.UseAuthorization();

// global error handler
app.UseMiddleware<ErrorHandlerMiddleware>();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


void AddAuthorizationPolicies()
{
    builder.Services.AddAuthorization(options =>
    {
        options.AddPolicy("EmployeeOnly", policy => policy.RequireClaim("EmployeeNumber"));
    });

    builder.Services.AddAuthorization(options =>
    {
        options.AddPolicy(Constants.Policies.RequireAdmin, policy => policy.RequireRole(Constants.Roles.Administrator));
        options.AddPolicy(Constants.Policies.RequireManager, policy => policy.RequireRole(Constants.Roles.Manager));
    });
}