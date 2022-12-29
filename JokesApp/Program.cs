using JokesApp.BAL;
using JokesApp.Concrete;
using JokesApp.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IJokesBusiness, JokesBusiness>();
builder.Services.AddTransient<IApiService, ApiService>();
builder.Services.Configure<JokesAPI>(builder.Configuration.GetSection("JokesAPI"));
builder.Services.Configure<ApiCreds>(builder.Configuration.GetSection("ApiCreds"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
