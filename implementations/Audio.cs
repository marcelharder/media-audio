using data.models;

namespace media_audio.Interfaces;

public class Audio : IAudio
{
    private readonly DataContext _context;
    public Audio(DataContext context)
    {
        _context = context;
    }

    public Task<IEnumerable<string>> GetAllAudioFiles(string username)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetSpecificAudioFile(int id)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetSpecificAlbum(int id)
    {
        throw new NotImplementedException();
    }

    public Task<string?> AddAudioFile(AlbumDetails albumDetails)
    {
        _context.Albums.Add(albumDetails);
        _context.SaveChanges();
        return Task.FromResult(albumDetails.AlbumTitle);
    }

    public Task<bool> DeleteAudioFile(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAudioFile(int id, string newFilePath)
    {
        throw new NotImplementedException();
    }

    
}