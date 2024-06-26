using BunnyWebApplication.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

 //  builder.Services.AddSwaggerGen();
builder.Services
 .AddDbContext<BunnyContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString(nameof(BunnyContext))));
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   /* app.UseSwagger();
    app.UseSwaggerUI();*/
}

app.UseHttpsRedirection();

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllers();
//app.MapFallbackToFile("/index.html");

app.Run();
