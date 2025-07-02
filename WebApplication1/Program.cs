using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

var builder = WebApplication.CreateBuilder(args);

// 🔹 1. Lire la chaîne de connexion
string? context = builder.Configuration.GetConnectionString("Connection");

// 🔹 2. Ajouter le DbContext dans le conteneur DI
builder.Services.AddDbContext<ContextDatabase>(options =>
    options.UseSqlServer(context));

// 🔹 3. Ajouter les autres services
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

// 🔹 4. Configuration de la pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();