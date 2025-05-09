using AgendamentoAPI.Context;
using AgendamentoAPI.Interface;
using AgendamentoAPI.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal; 

var builder = WebApplication.CreateBuilder(args);

// Corrected code: Use the DbContextOptionsBuilder to configure MySQL
builder.Services.AddDbContext<ApiContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 42))
    )
);

// Add services to the container.  
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle  
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProfissionalRepository, ProfissionalRepository>();
builder.Services.AddScoped<IServicoRepository, ServicoRepositorio>();
builder.Services.AddScoped<IClienteRepository, ClienteRepositorio>();
builder.Services.AddSingleton<DbContextServices>();

// Fix: Remove the duplicate `var app` declaration
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
