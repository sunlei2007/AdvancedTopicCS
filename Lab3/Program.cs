using Lab3.Data;
using Microsoft.EntityFrameworkCore;
using Lab3.Model;

var builder = WebApplication.CreateBuilder(args);

// SERVICES
builder.Services.AddDbContext<DBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("TransitDB"));
});
var app = builder.Build();

app.MapGet("/route", (int id, DBContext db) =>
{
    Lab3.Model.Route route = db.Routes.Find(id);

    return Results.Ok(route);
});

app.MapGet("/stop", (int id, DBContext db) =>
{
    Stop stop = db.Stops.Find(id);

    return Results.Ok(stop);
});

app.MapGet("/stopschedule", (int number, int top, DBContext db) =>
{
    StopSchedule stopSchedule = db.StopSchedule.Where(c=>c.Stop.Number==number && c.Route.Number==top).FirstOrDefault();

    return Results.Ok(stopSchedule);
});

app.Run();
 