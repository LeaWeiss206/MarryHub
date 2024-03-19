using Bl;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSingleton<BlManager>();



//builder.Services.AddScoped<ICitiesRepo, CitiesRepoBl>();
//builder.Services.AddScoped<ICategoriesRepo,CategoryRepo>();
//builder.Services.AddScoped<Dal.DalApi.ICitiesRepo, Dal.DalImplementation.CitiesRepo>();
//builder.Services.AddScoped<Dal.DalApi.ICategoriesRepo, Dal.DalImplementation.CategoriesRepo>();


var app = builder.Build();

app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.Run();
