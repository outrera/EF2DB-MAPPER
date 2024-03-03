using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Configuración de DbContext
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 21)),
        mysqlOptions => mysqlOptions.SchemaBehavior(MySqlSchemaBehavior.Ignore)));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<MyDbContext>();
    if (context.Database.EnsureCreated())
    {
        Console.WriteLine("La base de datos y las entidades han sido creadas.");
    }
}

app.MapGet("/", () => "Hello World!");

app.Run();