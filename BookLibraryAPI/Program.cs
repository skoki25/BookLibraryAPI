using BookLibraryAPI.Installation;
using BookLibraryAPI.Models;
using BookLibraryAPI.Services;
using BookLibraryAPI.Services.Automatic;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
var environmentName = builder.Environment.EnvironmentName;
IConfigurationRoot configuration = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    .AddJsonFile("appsettings.json")
    .Build();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LibraryDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ConnectionString")));
builder.Services.AddDbContext<LibraryDbContext>();
builder.Services.AddHostedService<AutomaticNoticeService>();
builder.Services.AddApplicationServices();
builder.Services.AddAuthenticationExtension();
builder.Services.AddSwaggerExtension();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseAuthorization();

app.MapControllers();

app.Run();