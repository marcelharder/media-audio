namespace media_audio.Interfaces;
public interface IAudio
{
    Task<IEnumerable<string>> GetAllAudioFiles(string username);
    Task<string> GetSpecificAudioFile(int id);
    Task<string> GetSpecificAlbum(int id);
    Task<string> AddAudioFile(string username, string filePath);
    Task<bool> DeleteAudioFile(int id);
    Task<bool> UpdateAudioFile(int id, string newFilePath);
}