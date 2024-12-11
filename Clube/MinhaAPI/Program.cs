using Microsoft.EntityFrameworkCore;
using MinhaAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost",
        policy => policy.WithOrigins("https://localhost:7208") // URL do Blazor
                        .AllowAnyHeader()
                        .AllowAnyMethod());
});


// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer("name=DefaultConnection");
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Usa a política de CORS
app.UseCors("AllowLocalhost");

app.MapControllers();

app.Run();

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
