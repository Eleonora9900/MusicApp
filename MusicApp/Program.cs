using MusicApp_BL.Interfaces;
using MusicApp_BL.Services;
using MusicApp_DL.Interfaces;
using MusicApp_DL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<ISongRepository, SongRepository>();
builder.Services.AddSingleton<IArtistRepository, ArtistRepository>();
builder.Services.AddSingleton<IAlbumRepository, AlbumRepository>();

builder.Services.AddSingleton<ISongService, SongService>();
builder.Services.AddSingleton<IAlbumService, AlbumService>();
builder.Services.AddSingleton<IArtistService, ArtistService>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

