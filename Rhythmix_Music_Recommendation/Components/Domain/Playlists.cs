using System.ComponentModel.DataAnnotations;

namespace Rhythmix_Music_Recommendation.Components.Domain
{
    public class Playlist
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        // This links the playlist to the logged-in user's account ID
        public string? UserId { get; set; }

        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
    }
}