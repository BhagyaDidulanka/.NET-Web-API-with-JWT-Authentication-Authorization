using System.ComponentModel.DataAnnotations;

namespace Authentication_and_Authorization___JWT_Tokens.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
