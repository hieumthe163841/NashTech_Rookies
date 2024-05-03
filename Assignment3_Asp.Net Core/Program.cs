using Assignment3_Asp.Net_Core;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Cấu hình Serilog
//builder.Host.UseSerilog((ctx, lc) => lc
//    .WriteTo.File("log/request-.txt",shared: true, rollingInterval: RollingInterval.Day)
//    .ReadFrom.Configuration(ctx.Configuration));

//Log.Logger = new LoggerConfiguration()
//    .WriteTo.File("logs/log.txt",
//    rollingInterval: RollingInterval.Minute)
//    .CreateLogger();
// Khởi tạo và cấu hình Serilog


builder.Host.UseSerilog((context,config) =>
{
    config.ReadFrom.Configuration(context.Configuration);
});
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor(); 
var app = builder.Build();

// Cấu hình request pipeline
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