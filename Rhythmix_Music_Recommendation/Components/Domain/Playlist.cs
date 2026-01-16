using Rhythmix_Music_Recommendation.Data;

namespace Rhythmix_Music_Recommendation.Components.Domain
{
    public class Playlist
    {
        public int PlaylistId { get; set; }
        public string Title { get; set; }
        public string? CoverImageUrl { get; set; }

        public string UserId { get; set; } = default!;          // FK to AspNetUsers
        public Rhythmix_Music_RecommendationUser User { get; set; } = default!;

        public ICollection<PlaylistSongs> PlaylistSongs { get; set; } = new List<PlaylistSongs>();


    }
}
