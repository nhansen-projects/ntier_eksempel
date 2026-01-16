using Microsoft.EntityFrameworkCore;
using ntier.BLL;
using ntier.BLL.Interfaces;
using ntier.DAL.Interfaces;
using ntier.DAL.Repositories;
using ntier.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Register DbContext with DI
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register services and repositories
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();