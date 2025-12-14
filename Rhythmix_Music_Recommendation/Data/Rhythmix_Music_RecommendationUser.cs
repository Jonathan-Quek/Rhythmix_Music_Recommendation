using Microsoft.AspNetCore.Identity;

namespace Rhythmix_Music_Recommendation.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class Rhythmix_Music_RecommendationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        
    }
}
