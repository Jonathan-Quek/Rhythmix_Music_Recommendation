namespace Rhythmix_Music_Recommendation.Components.Domain
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string MusicBrainzId { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string? CoverImageUrl { get; set; }
        public int? ReleaseYear { get; set; }
        public ICollection<Song> Songs { get; set; } = new List<Song>();
    }
}
