using Api_Rest_Integrator.Core.Interface.Repository;
using Api_Rest_Integrator.Core.Interface.Service;
using Api_Rest_Integrator.Infrastructure.Data.Repositories;
using Api_Rest_Integrator.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IGetCurrencyService, GetCurrencieTypeUseCase>();
builder.Services.AddScoped<IGetCurrencyRepository, GetCurrencyRepository>();

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
