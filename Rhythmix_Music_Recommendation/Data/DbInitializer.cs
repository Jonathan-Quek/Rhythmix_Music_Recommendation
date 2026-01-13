using Rhythmix_Music_Recommendation.Components.Domain;
using System.ComponentModel;
using System.Text.Json;

namespace Rhythmix_Music_Recommendation.Data
{
    public static class DbInitializer
    {
        public static async Task SeedSongsAsync(IServiceProvider services)
        {



            using var scope = services.CreateScope();
            var context = scope.ServiceProvider
                .GetRequiredService<Rhythmix_Music_RecommendationContext>();

            if (context.Songs.Any())
                return; // Prevent reseeding

            var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd(
                "SMSS/1.0 (jonathanquek14@hotmail.com)"
            );
            var genreSeeds = new Dictionary<string, int>
            {
                {"Pop", 20},
                {"Rock", 20},
                {"Hip-Hop", 20},
                {"Country", 20},
                {"Jazz", 20},
                {"Classical", 20},
                {"Electronic", 20},
                {"R&B", 20},
                {"Reggae", 20},
                {"Metal", 20}
            };




            foreach (var seed in genreSeeds)
            {
                string genre = seed.Key;
                int limit = seed.Value;


                var url =
                    "http://musicbrainz.org/ws/2/recording/?" +
                    $"query=tag:{genre}&limit={limit}&fmt=json&inc=releases";

                var response = await client.GetStringAsync(url);

                using var doc = JsonDocument.Parse(response);
                var recordings = doc.RootElement.GetProperty("recordings");

                foreach (var r in recordings.EnumerateArray())
                {
                    int? releaseYear = null;

                    if (r.TryGetProperty("first-release-date", out var dateProp))
                    {
                        var dateString = dateProp.GetString();

                        if (!string.IsNullOrEmpty(dateString) &&
                            dateString.Length >= 4 &&
                            int.TryParse(dateString.Substring(0, 4), out int year))
                        {
                            releaseYear = year;
                        }
                    }

                    string? coverUrl = null;

                    if (r.TryGetProperty("releases", out var releases) &&
                        releases.GetArrayLength() > 0)
                    {
                        var releaseId = releases[0].GetProperty("id").GetString();
                        coverUrl = $"https://coverartarchive.org/release/{releaseId}/front";
                    }

                    var album = releases.GetArrayLength() > 0
                                    ? releases[0].GetProperty("title").GetString()
                                    : null;

                    var song = new Song
                    {
                        MusicBrainzId = r.GetProperty("id").GetString(),
                        Title = r.GetProperty("title").GetString(),
                        Artist = r.GetProperty("artist-credit")[0]
                                    .GetProperty("name").GetString(),
                        Genre = genre,
                        ReleaseYear = releaseYear,
                        Album = album,
                        CoverImageUrl = coverUrl
                    };

                    // Skip songs with title "[untitled]" (case-insensitive)
                    if (!string.Equals(song.Title, "[untitled]", StringComparison.OrdinalIgnoreCase))
                    {
                        context.Songs.Add(song);
                    }
                }

                await Task.Delay(1000); // Respectful delay between requests
            }
            await context.SaveChangesAsync();

            

        }


    }
}


