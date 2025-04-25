using AgendamentoAPI.Infraestutura;
using AgendamentoAPI.Repository;
var builder = WebApplication.CreateBuilder(args);



var configuration = builder.Configuration.GetSection("supabase");
var url = configuration["url"];
var key = configuration["key"];

if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(key))
{
    throw new Exception("Supabase URL or Key is not configured.");
}


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IRepository, Infra>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
