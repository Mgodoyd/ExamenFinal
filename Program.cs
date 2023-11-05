using Examen_final_DW.Data;
using Examen_final_DW.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Conexion db
builder.Services.AddDbContext<ApplicationDBContext>(options =>
options.UseSqlServer("name=ConnectionStrings:azureDBConnect"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IExpediente, ServiceExpediente>();
builder.Services.AddScoped<IDetalle, ServiceDetalle>();

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
