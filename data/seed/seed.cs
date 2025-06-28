using System.Text.Json;
using data.models;
using media_audio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MediaAudio.Data.Seed;



public class Seed
{

    private readonly IAudio _audioService;

    public Seed(IAudio audioService)
    {
        _audioService = audioService;
    }


    public async Task SeedDataAsync()
    {
        // This method is used to seed the database with initial data.
        // It can be called during application startup or migration.
        // Add your seeding logic here.
        var userData = await System.IO.File.ReadAllTextAsync("data/seed/Albums.json");
        var users = JsonSerializer.Deserialize<List<AlbumDetails>>(userData);
        if (users is null || !users.Any())
        {
            throw new InvalidOperationException("No albums found in the seed data.");
        }
        foreach (var album in users)
        {
            // Add logic to process each album, e.g., add to database context
            await _audioService.AddAudioFile(album);

        }
    }
}