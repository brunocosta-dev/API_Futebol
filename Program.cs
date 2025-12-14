using FutebolApi;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=futebol.db"));

var app = builder.Build();

app.MapGet("/times", async (AppDbContext db)=>
{
    return await db.Times.ToListAsync();
});

app.MapGet("/times/{id}", async (int id, AppDbContext db)=>
{
    var time = await db.Times.FindAsync(id);
    return time is not null ? Results.Ok(time): Results.NotFound("Time não encontrado");
});

app.Run();
