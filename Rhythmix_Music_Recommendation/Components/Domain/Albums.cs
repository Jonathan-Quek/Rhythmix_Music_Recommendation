using System.ComponentModel.DataAnnotations;

namespace Rhythmix_Music_Recommendation.Components.Domain
{
    public class Album
    {
        [Key]
        public Guid AlbumId { get; set; } = Guid.NewGuid();
        public string MusicBrainzId { get; set; } = "";

        // This connects the album to a specific User ID in the database
        public string? UserId { get; set; }
        public string? CoverImageUrl { get; set; }
        public string Title { get; set; } = "";
        public string Artist { get; set; } = "";
        public string Bio { get; set; } = "";
        public int? ReleaseYear { get; set; }
        public ICollection<Song>? Songs { get; set; } = new List<Song>();
    }
}
