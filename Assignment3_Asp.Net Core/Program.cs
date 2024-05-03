using Assignment3_Asp.Net_Core;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context,config) =>
{
    config.ReadFrom.Configuration(context.Configuration);
});
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor(); 
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();
app.UseLoggingMiddleware(); 

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();