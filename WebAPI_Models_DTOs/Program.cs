using Microsoft.EntityFrameworkCore;
using WebAPI_Models_DTOs.DBContext;
using WebAPI_Models_DTOs.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<CodeFristDbContext>( options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<CodeFristDbContext>();
builder.Services.AddScoped<IPlayerService, PlayerService>();

builder.Services.AddAutoMapper(cfg =>
{
    cfg.LicenseKey = "<license key here>";
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
