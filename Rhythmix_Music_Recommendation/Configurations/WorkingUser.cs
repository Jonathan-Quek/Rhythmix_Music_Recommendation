using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rhythmix_Music_Recommendation.Data;

namespace Rhythmix_Music_Recommendation.Configurations
{
    public class WorkingUserSeed : IEntityTypeConfiguration<Rhythmix_Music_RecommendationUser>
    {
        public void Configure(EntityTypeBuilder<Rhythmix_Music_RecommendationUser> builder)
        {
            var hasher = new PasswordHasher<Rhythmix_Music_RecommendationUser>();
            builder.HasData(
                new Rhythmix_Music_RecommendationUser
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login
                },

                new Rhythmix_Music_RecommendationUser
                {
                    Id = "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d",
                    Email = "jonathan@mail.com",
                    NormalizedEmail = "JONATHAN@MAIL.COM",
                    FirstName = "Jonathan",
                    LastName = "Quek",
                    UserName = "JonQuek",
                    NormalizedUserName = "JONQUEK",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true

                }
                );
        }

        
    }
}