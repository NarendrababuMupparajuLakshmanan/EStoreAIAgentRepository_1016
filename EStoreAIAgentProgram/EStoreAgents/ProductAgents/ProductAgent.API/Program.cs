using Microsoft.EntityFrameworkCore;
using ProductAgent.Application;
using ProductAgent.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterServices();

builder.Services.AddControllers();

string _connectionstring = builder.Configuration.GetConnectionString("EStoreDBConnection");

//IOC ---> Inversion of Control
builder.Services.AddDbContext<ProductRepository>(options =>
{
    options.UseSqlServer(_connectionstring);
});


//Add Swashe Buckle to Services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

app.UseRouting();

app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI();

//enable swagger as a default page
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");

    // Make Swagger the default page
    c.RoutePrefix = string.Empty;
});

app.Run();
