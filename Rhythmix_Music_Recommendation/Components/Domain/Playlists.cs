using System.ComponentModel.DataAnnotations;

namespace Rhythmix_Music_Recommendation.Components.Domain
{
    public class Playlist
    {
        [Key]
        public Guid PlaylistId { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = "";
        public string? CoverImageUrl { get; set; }

        // This links the playlist to the logged-in user's account ID
        public string? UserId { get; set; }
        public string Description { get; set; } = "";
        public ICollection<PlaylistSongs>? PlaylistSongs { get; set; } = new List<PlaylistSongs>();
    }
}