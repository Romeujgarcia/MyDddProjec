using Microsoft.EntityFrameworkCore;
using MyDddProject.Infrastructure.Data;
using MyDddProject.Application.Services;
using MyDddProject.Domain.Repositories;
using MyDddProject.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configure a conexão de banco de dados
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseSqlServer(connectionString));

// Configurar DI para repositórios e serviços
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ProductService>();

// Adicione suporte a controllers
builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();

