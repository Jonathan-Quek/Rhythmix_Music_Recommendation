using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rhythmix_Music_Recommendation.Components.Domain;
using Rhythmix_Music_Recommendation.Configurations.Entities;

namespace Rhythmix_Music_Recommendation.Data
{
    public class Rhythmix_Music_RecommendationContext : DbContext
    {
        public Rhythmix_Music_RecommendationContext (DbContextOptions<Rhythmix_Music_RecommendationContext> options)
            : base(options)
        {
        }

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
}
