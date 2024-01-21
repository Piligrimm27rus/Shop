using Ninject.Extensions.DependencyInjection;
using Ninject;
using System.Reflection;
using System;
using Ninject.Modules;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//setup Ninject
builder.Host.UseServiceProviderFactory(new NinjectServiceProviderFactory())
    .ConfigureContainer<IKernel>(kernel =>
    {
        kernel.Load
        (
            Assembly.Load("Application"),
            Assembly.Load("Infrastructure")
        );
    });

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
