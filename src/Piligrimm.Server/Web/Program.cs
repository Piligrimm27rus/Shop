using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ninject;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// //setup Ninject
// var kernel = new StandardKernel();
// // load modules
// kernel.Load(Assembly.GetExecutingAssembly());
// var registrations = NinjectRegistrations.LoadDependenses();
// DependencyResolver.SetResolver(registrations);
var kernel = new StandardKernel(); 
kernel.Load(Assembly.GetExecutingAssembly());
// //Database
// string connection = builder.Configuration.GetConnectionString("DataAccessPostgreSqlProvider");
// builder.Services.AddDbContext<InfrastuctureContext>(options => options.UseNpgsql(connection));
// builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connection));

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
