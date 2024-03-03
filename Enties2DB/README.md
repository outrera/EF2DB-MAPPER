# iS2 - Paso a paso

Este es un tutorial paso a paso para configurar Entity Framework Core con MySQL en una aplicación web de ASP.NET Core.

## Requisitos
Para reconstruir una base de datos desde un modelo de Entity Framework (EF) en MySQL, puedes utilizar las migraciones de EF. Aquí te dejo un ejemplo paso a paso de cómo podrías hacerlo:

1. Asegúrate de tener instalado el paquete `Pomelo.EntityFrameworkCore.MySql` en tu proyecto. Este paquete permite a EF trabajar con MySQL.

2. Configura tu `DbContext` para usar MySQL. Esto se hace en el método `OnConfiguring` de tu `DbContext`. Aquí hay un ejemplo:

```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseMySql("server=localhost;database=miBaseDeDatos;user=miUsuario;password=miContraseña",
        new MySqlServerVersion(new Version(8, 0, 21)));
}
```

3. Asegúrate de que tu modelo EF esté configurado correctamente. Cada clase que represente una tabla en la base de datos debe ser un `DbSet` en tu `DbContext`.

4. Ejecuta el comando `Add-Migration InitialCreate` en la consola del administrador de paquetes. Esto creará una migración que representa la creación inicial de la base de datos.

5. Ejecuta el comando `Update-Database` en la consola del administrador de paquetes. Esto aplicará la migración a la base de datos, creando la base de datos y todas las tablas.

Por favor, reemplaza "miBaseDeDatos", "miUsuario" y "miContraseña" con tus propios valores.


# Paso 1: Configuración de Entity Framework Core y MySQL

Hasta ahora, hemos realizado los siguientes pasos:

1. **Instalación del paquete `Pomelo.EntityFrameworkCore.MySql`**: Este paquete permite a Entity Framework trabajar con MySQL. Lo instalamos utilizando el comando CLI `dotnet add package Pomelo.EntityFrameworkCore.MySql`.

2. **Creación de la clase `MyDbContext`**: Esta clase hereda de `DbContext` y es la principal clase que coordina la funcionalidad de Entity Framework para un modelo de datos. Configuramos esta clase para usar MySQL en el método `OnConfiguring`.

```csharp
public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("server=localhost;database=miBaseDeDatos;user=miUsuario;password=miContraseña",
            new MySqlServerVersion(new Version(8, 0, 21)));
    }

    // Aquí puedes agregar tus DbSets, por ejemplo:
    // public DbSet<TuClase> TuClases { get; set; }
}
```

3. **Configuración de `MyDbContext` en `Program.cs`**: Configuramos nuestro `DbContext` en el método `ConfigureServices` de `Program.cs`.

```csharp
var builder = WebApplication.CreateBuilder(args);

// Agrega esto para configurar tu DbContext
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseMySql("server=localhost;database=miBaseDeDatos;user=miUsuario;password=miContraseña",
        new MySqlServerVersion(new Version(8, 0, 21))));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
```

Por favor, recuerda reemplazar "miBaseDeDatos", "miUsuario" y "miContraseña" con tus propios valores.

## Para este proyecto, necesitarás los siguientes paquetes NuGet:

- `Microsoft.EntityFrameworkCore`: Este paquete es el núcleo de Entity Framework Core.
- `Pomelo.EntityFrameworkCore.MySql`: Este paquete permite a Entity Framework Core trabajar con MySQL.
- `Microsoft.EntityFrameworkCore.Design`: Este paquete es necesario para las herramientas de Entity Framework Core, como las migraciones.

Puedes instalar estos paquetes utilizando los siguientes comandos en la terminal:

```shell
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Pomelo.EntityFrameworkCore.MySql
dotnet add package Microsoft.EntityFrameworkCore.Design
```

Por favor, asegúrate de ejecutar estos comandos en el directorio del proyecto.

# Paso 2: Definición de entidades y configuración de DbSet

En este paso, hemos definido las entidades que representarán las tablas en la base de datos y las hemos agregado a nuestro `DbContext`. Además, hemos instalado los paquetes necesarios para trabajar con Entity Framework Core y MySQL.

1. **Instalación de paquetes necesarios**: Hemos instalado los siguientes paquetes NuGet:

```shell
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Pomelo.EntityFrameworkCore.MySql
dotnet add package Microsoft.EntityFrameworkCore.Design
```

Estos paquetes son necesarios para trabajar con Entity Framework Core y MySQL, y para utilizar las herramientas de Entity Framework Core, como las migraciones.

2. **Definición de la entidad `Usuario`**: Hemos creado una clase `Usuario` que representa la tabla `Usuarios` en la base de datos. Cada propiedad en la clase `Usuario` representa una columna en la tabla `Usuarios`.

```csharp
public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Username { get; set; }
    public string RefreshToken { get; set; }
    public string Salt { get; set; }
    public bool IsCompletedProfile { get; set; }
    public bool IsAdmin { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
```

3. **Adición de `DbSet` a `MyDbContext`**: Hemos agregado un `DbSet` para la clase `Usuario` en nuestro `DbContext`. Esto permite a Entity Framework Core realizar operaciones en la tabla `Usuarios` de la base de datos.

```csharp
public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("server=localhost;database=miBaseDeDatos;user=miUsuario;password=miContraseña",
            new MySqlServerVersion(new Version(8, 0, 21)));
    }
}
```

4. **Creación y aplicación de migraciones**: Hemos creado una migración que representa la creación de la tabla `Usuarios` en la base de datos. Luego, aplicamos esta migración a la base de datos.

```shell
dotnet ef migrations add CrearTablaUsuarios
dotnet ef database update
```

Por favor, recuerda reemplazar "miBaseDeDatos", "miUsuario" y "miContraseña" con tus propios valores. Además, asegúrate de agregar tus propias clases y DbSets a `MyDbContext` según sea necesario.

# Paso 3: Configuración de la cadena de conexión en `appsettings.json`

En este paso, vamos a mover la cadena de conexión a nuestro archivo `appsettings.json`. Esto es una buena práctica ya que nos permite mantener la configuración de la base de datos separada del código, lo que facilita los cambios en la configuración sin tener que modificar el código.

1. **Agrega la cadena de conexión a `appsettings.json`**: En tu archivo `appsettings.json`, agrega una nueva sección "ConnectionStrings" con una entrada para tu base de datos. Aquí hay un ejemplo:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;database=miBaseDeDatos;user=miUsuario;password=miContraseña"
  }
}
```

Por favor, recuerda reemplazar "miBaseDeDatos", "miUsuario" y "miContraseña" con tus propios valores.

2. **Modifica `MyDbContext` para usar la cadena de conexión de `appsettings.json`**: Ahora, en lugar de tener la cadena de conexión directamente en tu `DbContext`, puedes obtenerla de `appsettings.json`. Aquí hay un ejemplo de cómo puedes hacerlo:

```csharp
public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; }
}
```

3. **Configura `MyDbContext` en `Program.cs` para usar la cadena de conexión de `appsettings.json`**: En `Program.cs`, puedes modificar la configuración de `MyDbContext` para usar la cadena de conexión de `appsettings.json`. Aquí hay un ejemplo:

```csharp
var builder = WebApplication.CreateBuilder(args);

// Agrega esto para configurar tu DbContext
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 21))));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
```

Con estos cambios, ahora estás utilizando la cadena de conexión de `appsettings.json` para configurar tu `DbContext`. Esto te permite cambiar fácilmente la configuración de la base de datos sin tener que modificar el código.

# Paso 4: Configuración de la aplicación y ejecución

En este paso, configuramos nuestra aplicación y la ejecutamos.

1. **Configuración de la aplicación**: En `Program.cs`, configuramos nuestra aplicación para usar `MyDbContext` con la cadena de conexión de `appsettings.json`. Aquí está el código:

```csharp
var builder = WebApplication.CreateBuilder(args);

// Configuración de DbContext
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 21))));

var app = builder.Build();
```

2. **Definición de la ruta principal**: Definimos una ruta principal ("/") que devuelve "Hello World!" cuando se accede a ella. Aquí está el código:

```csharp
app.MapGet("/", () => "Hello World!");
```

3. **Ejecución de la aplicación**: Finalmente, ejecutamos nuestra aplicación con `app.Run()`. Aquí está el código:

```csharp
app.Run();
```

Con estos pasos, hemos configurado y ejecutado nuestra aplicación. Ahora, si accedes a `http://localhost:5000/` en tu navegador, deberías ver "Hello World!".

# Paso 5: Resumen de la Configuración y Ejecución de la Aplicación

En este paso, vamos a resumir todo lo que hemos hecho hasta ahora para configurar y ejecutar nuestra aplicación.

1. **Instalación de paquetes necesarios**: Instalamos los paquetes NuGet necesarios para trabajar con Entity Framework Core y MySQL.

2. **Creación de la clase `MyDbContext`**: Creamos una clase `MyDbContext` que hereda de `DbContext` y es la principal clase que coordina la funcionalidad de Entity Framework para un modelo de datos.

3. **Configuración de `MyDbContext` en `Program.cs`**: Configuramos nuestro `DbContext` en el método `ConfigureServices` de `Program.cs`.

4. **Definición de la entidad `Usuario`**: Creamos una clase `Usuario` que representa la tabla `Usuarios` en la base de datos.

5. **Adición de `DbSet` a `MyDbContext`**: Agregamos un `DbSet` para la clase `Usuario` en nuestro `DbContext`.

6. **Creación y aplicación de migraciones**: Creamos una migración que representa la creación de la tabla `Usuarios` en la base de datos y luego aplicamos esta migración a la base de datos.

7. **Configuración de la cadena de conexión en `appsettings.json`**: Movimos la cadena de conexión a nuestro archivo `appsettings.json` y modificamos `MyDbContext` para usar esta cadena de conexión.

8. **Configuración de la aplicación y ejecución**: Finalmente, configuramos nuestra aplicación para usar `MyDbContext` con la cadena de conexión de `appsettings.json` y definimos una ruta principal ("/") que devuelve "Hello World!" cuando se accede a ella. Luego, ejecutamos nuestra aplicación.

Con estos pasos, hemos configurado y ejecutado nuestra aplicación. Ahora, si accedes a `http://localhost:5000/` en tu navegador, deberías ver "Hello World!".

# Federata Paso Actual: Configuración de la Base de Datos y Ejecución de la Aplicación

En este paso, vamos a configurar nuestra base de datos y ejecutar nuestra aplicación. Para ello, vamos a realizar las siguientes modificaciones en nuestros archivos `Program.cs` y `MyDbContext.cs`.

## Modificaciones en `Program.cs`

En `Program.cs`, vamos a configurar nuestro `DbContext` para usar la cadena de conexión de `appsettings.json`. Además, vamos a asegurarnos de que la base de datos se cree al inicio de nuestra aplicación y vamos a imprimir un mensaje en la consola cuando esto suceda.

Aquí está el código modificado para `Program.cs`:

```csharp
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Configuración de DbContext
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 21))));

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
```

## Modificaciones en `MyDbContext.cs`

En `MyDbContext.cs`, vamos a modificar nuestra clase para que acepte un objeto `IConfiguration` en su constructor. Luego, vamos a usar este objeto para obtener la cadena de conexión de `appsettings.json`.

Aquí está el código modificado para `MyDbContext.cs`:

```csharp
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class MyDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public MyDbContext(DbContextOptions<MyDbContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 21)));
    }
}
```

Con estas modificaciones, nuestra aplicación ahora debería ser capaz de crear la base de datos al inicio y obtener la cadena de conexión de `appsettings.json`.