using CCBackend;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Writers;

var builder = WebApplication.CreateBuilder(args);
// Cors 
builder.Services.AddCors(options => options.AddPolicy("allowWebApp",
        builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()
        )
);


//indicamos cual es el string de conexion a la base de datos (el que se configura en appsettings.json)
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ccDbContext>(options =>
    {
        options.UseSqlServer(connectionString);
    }
);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ccDbContext>();
    context.Database.Migrate();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("allowWebApp");

app.Run();
