using Finger_Print_WebApi.Data;
using Finger_Print_WebApi.Repos.IRepo;
using Finger_Print_WebApi.Repos.Repo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Database
builder.Services.AddDbContext<FingerPrintDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("FingerPrint"));
});
//Repository
builder.Services.AddScoped<IEmployeeRepository,EmployeeRepository>();


//Automapper
builder.Services.AddAutoMapper(typeof(Program).Assembly);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
