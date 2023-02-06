using HGPolloLovers.Application.Contrats;
using HGPolloLovers.Application.Impl;
using HGPolloLovers.Domain.Contracts;
using HGPolloLovers.Domain.Impl;
using HGPolloLovers.Infrastructure.Impl;
using HGPolloLovers.Repository.Contrats;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICustomersApplication, CustomersApplication>();
builder.Services.AddScoped<IGetDataFromRepository, GetDataFromRepository>();
builder.Services.AddScoped<IGetDataService, GetDataService>();
builder.Services.AddScoped<ISplitterService, SplitterService>();

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
