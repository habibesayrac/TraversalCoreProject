using Microsoft.EntityFrameworkCore;
using SignalRApi.DAL;
using SignalRApi.Hubs;
using SignalRApi.Model;

var builder = WebApplication.CreateBuilder(args);

//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
// Add services to the container.
//builder.Services.AddEntityFrameworkNpgsql().AddDbContext<Context>(opt =>
//opt.UseNpgsql(connectionString));

builder.Services.AddScoped<VisitorService>();
builder.Services.AddSignalR();
builder.Services.AddDbContext<Context>();
//builder.Services.AddHttpClient();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
//app.MapHub<VisitorHub>("/chatHub");