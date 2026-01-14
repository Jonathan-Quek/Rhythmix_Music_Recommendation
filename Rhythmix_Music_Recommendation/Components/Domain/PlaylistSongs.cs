namespace Rhythmix_Music_Recommendation.Components.Domain;

public class PlaylistSongs
{
    public int PlaylistId { get; set; }
    public Playlist Playlist { get; set; } = default!;

    public int SongId { get; set; }
    public Song Song { get; set; } = default!;
}
