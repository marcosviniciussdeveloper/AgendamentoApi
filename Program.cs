using AgendamentoAPI.Context;
using AgendamentoAPI.Interface;
using AgendamentoAPI.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

var builder = WebApplication.CreateBuilder(args);

// Configuração do banco de dados MySQL
builder.Services.AddDbContext<ApiContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 42))
    )
);

// Serviços e repositórios
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProfissionalRepository, ProfissionalRepository>();
builder.Services.AddScoped<IServicoRepository, ServicoRepositorio>();
builder.Services.AddScoped<IAgendamentoRepository, AgendamentoRepositorio>();
builder.Services.AddScoped<IClienteRepository, ClienteRepositorio>();
builder.Services.AddSingleton<DbContextServices>();

// ⚠️ Só aplica configuração manual de portas se estiver rodando em produção (ex: Docker)
//builder.WebHost.ConfigureKestrel(options =>
//{
  //  options.ListenAnyIP(8080); // Apenas HTTP, funciona 100% no Docker
//});
   


// Constrói a aplicação
var app = builder.Build();

// Pipeline HTTP

    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors();

app.MapControllers();

app.Run();

