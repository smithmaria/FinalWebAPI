using FinalWebAPI.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using NSwag.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddOpenApiDocument();

var app = builder.Build();

app.UseOpenApi();        // serves /swagger/v1/swagger.json
app.UseSwaggerUi();      // serves the Swagger UI page

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();