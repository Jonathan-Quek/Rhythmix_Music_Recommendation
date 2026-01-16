using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rhythmix_Music_Recommendation.Components.Domain;
using Rhythmix_Music_Recommendation.Configurations;
using Rhythmix_Music_Recommendation.Data;
using Rhythmix_Music_Recommendation.Components.Domain; // Added to access Playlist and Album
using System.Reflection.Emit;

namespace Rhythmix_Music_Recommendation.Data
{
    public class Rhythmix_Music_RecommendationContext(DbContextOptions<Rhythmix_Music_RecommendationContext> options) : IdentityDbContext<Rhythmix_Music_RecommendationUser>(options)
    {
        // Your existing Login/Register tables
        public DbSet<StaffLogin> StaffLogin { get; set; } = default!;
        public DbSet<UserLogin> UserLogin { get; set; } = default!;
        public DbSet<UserRegister> UserRegister { get; set; } = default!;

        

        public DbSet<Rhythmix_Music_Recommendation.Components.Domain.StaffLogin> StaffLogin { get; set; } = default!;
        public DbSet<Rhythmix_Music_Recommendation.Components.Domain.UserLogin> UserLogin { get; set; } = default!;
        public DbSet<Rhythmix_Music_Recommendation.Components.Domain.UserRegister> UserRegister { get; set; } = default!;
        public DbSet<Rhythmix_Music_Recommendation.Components.Domain.Song> Songs { get; set; } = default!;
        public DbSet<Rhythmix_Music_Recommendation.Components.Domain.Album> Albums { get; set; } = default!;
        public DbSet<Rhythmix_Music_Recommendation.Components.Domain.Playlist> Playlists { get; set; } = default!;
        public DbSet<Rhythmix_Music_Recommendation.Components.Domain.PlaylistSongs> PlaylistSongs { get; set; } = default!;
        // NEW: Tables for persistent music storage
        public DbSet<Playlist> Playlists { get; set; } = default!;
        public DbSet<Album> Albums { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<PlaylistSongs>()
                .HasKey(ps => new { ps.PlaylistId, ps.SongId });

            builder.Entity<PlaylistSongs>()
                .HasOne(ps => ps.Playlist)
                .WithMany(p => p.PlaylistSongs)
                .HasForeignKey(ps => ps.PlaylistId);

            builder.Entity<PlaylistSongs>()
                .HasOne(ps => ps.Song)
                .WithMany() // or .WithMany(s => s.PlaylistSongs) if you add it
                .HasForeignKey(ps => ps.SongId);


            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new WorkingUserSeed());

            builder.ApplyConfiguration(new WorkingUserSeed());

            builder.Entity<Song>()
                .HasIndex(s => s.MusicBrainzId)
                .IsUnique();

            base.OnModelCreating(builder);

        }
    }
} // Rhythmix_Music_RecommendationContext
            // Optional: Ensure the relationship is clear if you want to enforce rules
            builder.Entity<Playlist>()
                .Property(p => p.Name)
                .IsRequired();
        }
    }
}