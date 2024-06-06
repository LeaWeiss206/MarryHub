using Api;
using Bl;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

builder.Services.AddControllers();

DBActions db = new DBActions(builder.Configuration);
string connStr = db.GetConnectionString("SiteDB");
builder.Services.AddSingleton<BlManager>(x=> new BlManager(connStr));


var app = builder.Build();

app.UseCors("AllowAllOrigins");

app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.Run();
