using Microsoft.EntityFrameworkCore;
using WebApplication1.Entieties;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<UniversityDbContext>() { 
    

app.MapGet("/", () => "Hello World!");

app.Run();