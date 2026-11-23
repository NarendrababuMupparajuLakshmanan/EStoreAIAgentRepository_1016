using Microsoft.EntityFrameworkCore;
using ProductAgent.Infrastructure;

var builder = WebApplication.CreateBuilder(args);


string _connectionstring = builder.Configuration.GetConnectionString("EStoreDBConnection");

builder.Services.AddDbContext<ProductRepository>(options =>
{
    options.UseSqlServer(_connectionstring);
});


var app = builder.Build();



app.Run();
