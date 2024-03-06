using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projectef;



var builder = WebApplication.CreateBuilder(args);
//Si da error, Anotar el error de UseInMemoryDataBase, anota a using Microsoft.EntityFrameworkCore;
//builder.Services.AddDbContext<TareasContext>(p=>p.Use.InMemoryDataBase("TareasDB"));//Nombre
builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("cnTareas"));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");


app.MapGet("/dbconexion", async ([FromServices] TareasContext DbContext) =>
{
  try{
    DbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria:"+ DbContext.Database.IsInMemory());

  }catch(Exception e)
  {return Results.Ok("Erros al verificar la base de datos en memoria:" + e.Message);
  }
  });


app.Run();
