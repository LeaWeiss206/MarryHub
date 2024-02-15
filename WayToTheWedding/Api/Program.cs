using Bl.BlApi;
using Bl.BlImplementaion;
using Dal;
using Dal.DalImplementation;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


DBActions db = new DBActions(builder.Configuration);
string connStr = db.GetConnectionString("SiteDB");
builder.Services.AddDbContext<SiteContext>(opt => opt.UseSqlServer(connStr));

builder.Services.AddScoped<ICitiesRepo, CitiesRepoBl>();
builder.Services.AddScoped<Dal.DalApi.ICitiesRepo, Dal.DalImplementation.CitiesRepo>();

var app = builder.Build();

app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.Run();
