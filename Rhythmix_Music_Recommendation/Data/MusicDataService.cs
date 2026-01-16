using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using Rhythmix_Music_Recommendation.Components.Domain;
using Rhythmix_Music_Recommendation.Data;
using System.Security.Claims;

namespace Rhythmix_Music_Recommendation.Services;

public class MusicDataService
{
    private readonly IDbContextFactory<Rhythmix_Music_RecommendationContext> _dbFactory;
    private readonly AuthenticationStateProvider _authStateProvider;

    public MusicDataService(IDbContextFactory<Rhythmix_Music_RecommendationContext> dbFactory, AuthenticationStateProvider authStateProvider)
    {
        _dbFactory = dbFactory;
        _authStateProvider = authStateProvider;
    }

    // These properties now fetch directly from the database based on the current user
    public List<Playlist> Playlists => GetUserPlaylists();
    public List<Album> Albums => GetUserAlbums();

    private string GetCurrentUserId()
    {
        var authState = _authStateProvider.GetAuthenticationStateAsync().Result;
        var user = authState.User;
        return user.Identity?.IsAuthenticated == true
            ? user.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "Guest"
            : "Guest";
    }

    private List<Playlist> GetUserPlaylists()
    {
        using var context = _dbFactory.CreateDbContext();
        var userId = GetCurrentUserId();
        return context.Playlists.Where(p => p.UserId == userId).ToList();
    }

    private List<Album> GetUserAlbums()
    {
        using var context = _dbFactory.CreateDbContext();
        var userId = GetCurrentUserId();
        return context.Albums.Where(a => a.UserId == userId).ToList();
    }

    public void AddPlaylist(Playlist p)
    {
        using var context = _dbFactory.CreateDbContext();
        p.UserId = GetCurrentUserId(); // Tag it with the user's ID
        context.Playlists.Add(p);
        context.SaveChanges();
    }

    public void AddAlbum(Album a)
    {
        using var context = _dbFactory.CreateDbContext();
        a.UserId = GetCurrentUserId(); // Tag it with the user's ID
        context.Albums.Add(a);
        context.SaveChanges();
    }

    public void DeletePlaylist(Guid id)
    {
        using var context = _dbFactory.CreateDbContext();
        var playlist = context.Playlists.FirstOrDefault(p => p.Id == id);
        if (playlist != null)
        {
            context.Playlists.Remove(playlist);
            context.SaveChanges();
        }
    }

    public void DeleteAlbum(Guid id)
    {
        using var context = _dbFactory.CreateDbContext();
        var album = context.Albums.FirstOrDefault(a => a.Id == id);
        if (album != null)
        {
            context.Albums.Remove(album);
            context.SaveChanges();
        }
    }

    public void UpdatePlaylist(Playlist updatedPlaylist)
    {
        using var context = _dbFactory.CreateDbContext();
        var existing = context.Playlists.FirstOrDefault(p => p.Id == updatedPlaylist.Id);
        if (existing != null)
        {
            existing.Name = updatedPlaylist.Name;
            existing.Description = updatedPlaylist.Description;
            context.SaveChanges();
        }
    }

    public void UpdateAlbum(Album updatedAlbum)
    {
        using var context = _dbFactory.CreateDbContext();
        var existing = context.Albums.FirstOrDefault(a => a.Id == updatedAlbum.Id);
        if (existing != null)
        {
            existing.Title = updatedAlbum.Title;
            existing.Artist = updatedAlbum.Artist;
            existing.Bio = updatedAlbum.Bio;
            context.SaveChanges();
        }
    }
}
