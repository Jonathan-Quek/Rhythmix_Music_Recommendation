namespace Rhythmix_Music_Recommendation.Components.Domain
{
    public class Song
    {
        public int SongId { get; set; }              // Internal PK
        public string MusicBrainzId { get; set; }    // MBID
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int? ReleaseYear { get; set; }
        public string? Album { get; set; } // Optional field for album name
        public string? CoverImageUrl { get; set; } // Optional field for cover image URL
    }
}
