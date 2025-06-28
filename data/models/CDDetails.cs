using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace data.models;

public class CDDetails
{
    [Key]
    public int CDId { get; set; }
    public ICollection<TrackDetails>? SongTitles { get; set; }
    public AlbumDetails? Album { get; set; }
    public int AlbumId { get; set; }


}
