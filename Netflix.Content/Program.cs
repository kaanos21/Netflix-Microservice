using Microsoft.EntityFrameworkCore;
using Netflix.Content.Context;
using Netflix.Content.Services.EpisodeServices;
using Netflix.Content.Services.SeasonServices;
using Netflix.Content.Services.SeriesServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ISeriesManager, SeriesManager>();
builder.Services.AddScoped<IEpisodeManager, EpisodeManager>();
builder.Services.AddScoped<ISeasonManager, SeasonManager>();

builder.Services.AddDbContext<NetflixContentContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

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
