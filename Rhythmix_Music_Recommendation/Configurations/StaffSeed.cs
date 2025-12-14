using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rhythmix_Music_Recommendation.Components.Domain;

namespace Rhythmix_Music_Recommendation.Configurations.Entities
{
    public class StaffSeed : IEntityTypeConfiguration<StaffLogin>
    {

        public void Configure(EntityTypeBuilder<StaffLogin> builder)
        {
            builder.HasData(

                        new StaffLogin
                        {

                            Id = 1,
                            Name = "Zong Han",
                            Password = "admin123",
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                            CreatedBy = "System",
                            UpdatedBy = "System"

                        }






                    );
        }
    }
}