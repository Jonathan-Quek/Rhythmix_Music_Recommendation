using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rhythmix_Music_Recommendation.Configurations
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                    UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                },

                new IdentityUserRole<string>
                {
                    RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                    UserId = "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d"
                }
                );
        }
    }
}