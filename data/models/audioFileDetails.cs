namespace data.models;

public class AudioFileDetails
{
    public int Id { get; set; }
    public string? AlbumTitle { get; set; }
    public string? CoverUrl { get; set; }

    public string? Artists { get; set; }
    public string[]? SongTitles { get; set; }
    public string[]? Allowed { get; set; }   
    public int year { get; set; }
    public int genre { get; set; }




}