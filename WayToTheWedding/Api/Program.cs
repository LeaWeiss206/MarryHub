using Api;
using Bl;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

DBActions db = new DBActions(builder.Configuration);
string connStr = db.GetConnectionString("SiteDB");
builder.Services.AddSingleton<BlManager>(x=> new BlManager(connStr));



//builder.Services.AddScoped<ICitiesRepo, CitiesRepoBl>();
//builder.Services.AddScoped<ICategoriesRepo,CategoryRepo>();
//builder.Services.AddScoped<Dal.DalApi.ICitiesRepo, Dal.DalImplementation.CitiesRepo>();
//builder.Services.AddScoped<Dal.DalApi.ICategoriesRepo, Dal.DalImplementation.CategoriesRepo>();


var app = builder.Build();

app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.Run();
