using System.ComponentModel.DataAnnotations;

namespace Colab.Requests
{
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]     
        public string Password { get; set; }
    }

}