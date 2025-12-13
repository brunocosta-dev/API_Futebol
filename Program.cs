using FutebolApi;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<appDbContext>(options => options.UseSqlite("Data Source=futebol.db"));

var app = builder.Build();

app.MapGet("/times", async (appDbContext db)=>
{
    return await db.Times.ToListAsync();
});

app.Run();
