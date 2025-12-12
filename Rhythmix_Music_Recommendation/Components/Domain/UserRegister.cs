namespace Rhythmix_Music_Recommendation.Components.Domain
{
    public class UserRegister : BaseDomainModel
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
    }
}
