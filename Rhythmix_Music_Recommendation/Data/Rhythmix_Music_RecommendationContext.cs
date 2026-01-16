using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rhythmix_Music_Recommendation.Configurations;
using Rhythmix_Music_Recommendation.Data;
using Rhythmix_Music_Recommendation.Components.Domain; // Added to access Playlist and Album

namespace Rhythmix_Music_Recommendation.Data
{
    public class Rhythmix_Music_RecommendationContext(DbContextOptions<Rhythmix_Music_RecommendationContext> options) : IdentityDbContext<Rhythmix_Music_RecommendationUser>(options)
    {
        // Your existing Login/Register tables
        public DbSet<StaffLogin> StaffLogin { get; set; } = default!;
        public DbSet<UserLogin> UserLogin { get; set; } = default!;
        public DbSet<UserRegister> UserRegister { get; set; } = default!;

        // NEW: Tables for persistent music storage
        public DbSet<Playlist> Playlists { get; set; } = default!;
        public DbSet<Album> Albums { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new WorkingUserSeed());

            // Optional: Ensure the relationship is clear if you want to enforce rules
            builder.Entity<Playlist>()
                .Property(p => p.Name)
                .IsRequired();
        }
    }
}