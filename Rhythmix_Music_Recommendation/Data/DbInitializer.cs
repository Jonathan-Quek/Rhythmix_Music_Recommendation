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

            var lim = 3;

            var genreSeeds = new Dictionary<string, int>
            {
                {"Pop", lim},
                {"Rock", lim},
                {"Hip-Hop", lim},
                {"Country", lim},
                {"Jazz", lim},
                {"Classical", lim},
                {"Electronic", lim},
                {"R&B", lim},
                {"Reggae", lim},
                {"Metal", lim}
            };




            foreach (var seed in genreSeeds)
            {
                string genre = seed.Key;
                int limit = seed.Value;



                var url = $"http://musicbrainz.org/ws/2/release/?query=tag:{genre}&limit={limit}&fmt=json";
                var response = await client.GetStringAsync(url);
                using var doc = JsonDocument.Parse(response);
                var releases = doc.RootElement.GetProperty("releases");

                foreach (var release in releases.EnumerateArray())
                {
                    var albumId = release.GetProperty("id").GetString();
                    var albumTitle = release.GetProperty("title").GetString();
                    var releaseYear = release.TryGetProperty("date", out var dateProp) && dateProp.GetString()?.Length >= 4
                        ? int.Parse(dateProp.GetString().Substring(0, 4))
                        : (int?)null;
                    var artist = release.GetProperty("artist-credit")[0].GetProperty("name").GetString();
                    var coverUrl = $"https://coverartarchive.org/release/{albumId}/front";

                    // Fetch songs for this album
                    var tracksUrl = $"http://musicbrainz.org/ws/2/recording?release={albumId}&fmt=json&inc=artist-credits";
                    var tracksResponse = await client.GetStringAsync(tracksUrl);
                    using var tracksDoc = JsonDocument.Parse(tracksResponse);
                    var recordings = tracksDoc.RootElement.GetProperty("recordings");

                    var album = new Album
                    {
                        MusicBrainzId = albumId,
                        Title = albumTitle,
                        Artist = artist,
                        CoverImageUrl = coverUrl,
                        ReleaseYear = releaseYear
                    };

                    foreach (var r in recordings.EnumerateArray())
                    {
                        var songTitle = r.GetProperty("title").GetString();


                        var song = new Song
                        {
                            MusicBrainzId = r.GetProperty("id").GetString(),
                            Title = songTitle,
                            Artist = r.GetProperty("artist-credit")[0].GetProperty("name").GetString(),
                            Genre = genre,
                            ReleaseYear = releaseYear,
                            CoverImageUrl = coverUrl,
                            Album = album
                        };
                        album.Songs.Add(song);
                    }
                    await Task.Delay(1000); // To respect rate limiting


                    context.Albums.Add(album);



                }

                await Task.Delay(1000);

            }
            await context.SaveChangesAsync();



        }


    }
}



