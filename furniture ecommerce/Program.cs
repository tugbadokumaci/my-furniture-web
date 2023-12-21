//using DataAccessLayer.Concrete;
//using Microsoft.EntityFrameworkCore;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//// Configure the database context
//builder.Services.AddDbContext<Context>(options =>
//{
//    options.UseMySql("Server=154.56.47.12; Database=u574456636_furniture_web; User=u574456636_tugba_web; Password=T96531533d*;");
//});

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    app.UseHsts();
//}
////builder.Services.AddHttpClient("MyWebApi", c =>
////{
////    c.BaseAddress = new Uri("https://localhost:7119/"); // FURNITURE API SOLUTINU ICIN OLAN WEB API 
////});
//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseRouting();
//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();



using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure the database context
builder.Services.AddDbContext<Context>(options =>
{
    options.UseMySql("Server=154.56.47.12; Database=u574456636_furniture_web; User=u574456636_tugba_web; Password=T96531533d*;", ServerVersion.AutoDetect("Server=154.56.47.12; Database=u574456636_furniture_web; User=u574456636_tugba_web; Password=T96531533d*;"), null);
});
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
