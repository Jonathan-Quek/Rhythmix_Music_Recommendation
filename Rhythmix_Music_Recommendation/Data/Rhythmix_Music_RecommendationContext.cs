using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rhythmix_Music_Recommendation.Configurations.Entities;
using Rhythmix_Music_Recommendation.Data;

namespace Rhythmix_Music_Recommendation.Data
{
    public class Rhythmix_Music_RecommendationContext(DbContextOptions<Rhythmix_Music_RecommendationContext> options) : IdentityDbContext<Rhythmix_Music_RecommendationUser>(options)
    {

        

        public DbSet<Rhythmix_Music_Recommendation.Components.Domain.StaffLogin> StaffLogin { get; set; } = default!;
        public DbSet<Rhythmix_Music_Recommendation.Components.Domain.UserLogin> UserLogin { get; set; } = default!;
        public DbSet<Rhythmix_Music_Recommendation.Components.Domain.UserRegister> UserRegister { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new StaffSeed());

            builder.ApplyConfiguration(new UserSeed());
        }
    }
} // Rhythmix_Music_RecommendationContext
