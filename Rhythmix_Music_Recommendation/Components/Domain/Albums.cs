using System.ComponentModel.DataAnnotations;

namespace Rhythmix_Music_Recommendation.Components.Domain
{
    public class Album
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        // This connects the album to a specific User ID in the database
        public string? UserId { get; set; }

        public string Title { get; set; } = "";
        public string Artist { get; set; } = "";
        public string Bio { get; set; } = "";
    }
}
