using Microsoft.EntityFrameworkCore;
using StudentCRUDOpretions_API.Implementations;
using StudentCRUDOpretions_API.Interface;
using StudentCRUDOpretions_API.Models;
using Scalar.AspNetCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<_360navigatorFrontRangeLiveV5TraineeContext>(e =>
{
	e.UseSqlServer(builder.Configuration.GetConnectionString("MyCon"));
});
builder.Services.AddTransient<IStudentInterface, StudentService>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();
Console.WriteLine(
	builder.Configuration.GetConnectionString("MyCon"));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.MapScalarApiReference();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
