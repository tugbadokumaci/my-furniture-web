//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using FurnitureWebAPI.Concrete;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddDbContext<MyDbContext>(options =>
//{
//    options.UseMySql("Server=154.56.47.12; Database=u574456636_furniture_web; User=u574456636_tugba_web; Password=T96531533d*;", ServerVersion.AutoDetect("Server=154.56.47.12; Database=u574456636_furniture_web; User=u574456636_tugba_web; Password=T96531533d*;"), null);
//});

//builder.Services.AddEndpointsApiExplorer();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseDeveloperExceptionPage();
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapGet("/", () => "Hello World!");

//app.MapGet("/products", async (MyDbContext db) =>
//    await db.Products.ToListAsync());

//// Add other endpoints and configurations as needed.

//app.Run();

using FurnitureWebAPI.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MyDbContext>(options =>
{
    options.UseMySql("Server=154.56.47.12; Database=u574456636_furniture_web; User=u574456636_tugba_web; Password=T96531533d*;");
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHttpClient();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGet("/products", async (MyDbContext db) =>
    await db.Products.ToListAsync());

app.Run();
