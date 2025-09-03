using Microsoft.EntityFrameworkCore;
using RealSite.DBProvider;
using RealSiteAPI.Repository;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration; 

builder.Services.AddControllers();
builder.Services.AddDbContextPool<AppDbContext>(
    options => options.UseSqlServer(configuration.GetConnectionString("RealSiteDB"))); 
builder.Services.AddTransient<IEmployee , EmployeeRepo>();



var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseCors(builder => builder
                         .AllowAnyOrigin()
                         .AllowAnyMethod()
                         .AllowAnyHeader()
                         .WithExposedHeaders("Content-Disposition"));
app.UseAuthorization();

app.MapControllers();

app.Run();
