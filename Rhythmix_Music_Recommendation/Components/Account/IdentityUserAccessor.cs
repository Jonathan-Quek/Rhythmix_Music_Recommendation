using Rhythmix_Music_Recommendation.Data;
using Microsoft.AspNetCore.Identity;

namespace Rhythmix_Music_Recommendation.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<Rhythmix_Music_RecommendationUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<Rhythmix_Music_RecommendationUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
