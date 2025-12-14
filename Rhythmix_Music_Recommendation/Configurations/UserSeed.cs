using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rhythmix_Music_Recommendation.Components.Domain;

namespace Rhythmix_Music_Recommendation.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<UserRegister>
    {
        public void Configure(EntityTypeBuilder<UserRegister> builder)
        {
            builder.HasData(
                        new UserRegister
                        {
                            Id = 1,
                            Username = "Jonathan",
                            Password = "password1",
                            Email = "Jonathan@Quek.ZhiYong",
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                            CreatedBy = "System",
                            UpdatedBy = "System"
                        }

                        );
        }
    }

}