namespace Rhythmix_Music_Recommendation.Components.Domain
{
    public class Playlist
    {
        public int PlaylistId { get; set; }
        public string Title { get; set; }
        public string? CoverImageUrl { get; set; }


        public ICollection<PlaylistSongs> PlaylistSongs { get; set; } = new List<PlaylistSongs>();


    }
}
