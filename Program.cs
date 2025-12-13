using FutebolApi;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<appDbContext>(options => options.UseSqlite("Data Source=futebol.db"));

var app = builder.Build();

app.MapGet("/", ()=>"Hello World!");

app.Run();
