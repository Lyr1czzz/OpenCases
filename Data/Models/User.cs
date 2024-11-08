using Microsoft.AspNetCore.Identity;

namespace OpenCases.Data.Models
{
    public class User : IdentityUser
    {
        public string? RefreshToken { get; set; }
        public DateTimeOffset? TokenCreated { get; set; }
        public DateTimeOffset? TokenExpires { get; set; }
    }
}