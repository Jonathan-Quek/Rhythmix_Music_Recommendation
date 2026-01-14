using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rhythmix_Music_Recommendation.Components.Domain;
using Rhythmix_Music_Recommendation.Configurations;
//using Rhythmix_Music_Recommendation.Configurations.Entities;
using Rhythmix_Music_Recommendation.Data;
using System.Reflection.Emit;

namespace Rhythmix_Music_Recommendation.Data
{
    public class Rhythmix_Music_RecommendationContext(DbContextOptions<Rhythmix_Music_RecommendationContext> options) : IdentityDbContext<Rhythmix_Music_RecommendationUser>(options)
    {

        

        public DbSet<Rhythmix_Music_Recommendation.Components.Domain.StaffLogin> StaffLogin { get; set; } = default!;
        public DbSet<Rhythmix_Music_Recommendation.Components.Domain.UserLogin> UserLogin { get; set; } = default!;
        public DbSet<Rhythmix_Music_Recommendation.Components.Domain.UserRegister> UserRegister { get; set; } = default!;
        public DbSet<Rhythmix_Music_Recommendation.Components.Domain.Song> Songs { get; set; } = default!;
        public DbSet<Rhythmix_Music_Recommendation.Components.Domain.Album> Albums { get; set; } = default!;
        public DbSet<Rhythmix_Music_Recommendation.Components.Domain.Playlist> Playlists { get; set; } = default!;
        public DbSet<Rhythmix_Music_Recommendation.Components.Domain.PlaylistSongs> PlaylistSongs { get; set; } = default!;

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


            //builder.ApplyConfiguration(new StaffSeed());

            //builder.ApplyConfiguration(new UserSeed());

            builder.ApplyConfiguration(new RoleSeed());

            builder.ApplyConfiguration(new UserRoleSeed());

            builder.ApplyConfiguration(new WorkingUserSeed());

            builder.Entity<Song>()
                .HasIndex(s => s.MusicBrainzId)
                .IsUnique();

            base.OnModelCreating(builder);

        }
    }
} // Rhythmix_Music_RecommendationContext
