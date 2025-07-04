using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

var builder = WebApplication.CreateBuilder(args);

// 🔹 1. Lire la chaîne de connexion
string? context = builder.Configuration.GetConnectionString("Connection");

// 🔹 2. Ajouter le DbContext
builder.Services.AddDbContext<ContextDatabase>(options =>
    options.UseSqlServer(context));

// 🔹 3. Ajouter services API + Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // <- Swagger
builder.Services.AddSwaggerGen();          // <- Swagger

var app = builder.Build();

// 🔹 4. Config de la pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();