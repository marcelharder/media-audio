namespace data.models;

public class TrackDetails
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public CDDetails cDDetails { get; set; } = null!;
    public int CDDetailsId { get; set; }
}