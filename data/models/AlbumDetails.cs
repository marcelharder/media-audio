using System.ComponentModel.DataAnnotations;

namespace data.models;

public class AlbumDetails
{
    [Key]
    public int AlbumId { get; set; }
    public string? WorldIdentfier { get; set; }
    public string? AlbumTitle { get; set; }
    public string? CoverUrl { get; set; }
    public string? Artists { get; set; }
    public ICollection<CDDetails>? Cds { get; set; }
    public string? Allowed { get; set; }
    public int Year { get; set; }
    public int Genre { get; set; }




}