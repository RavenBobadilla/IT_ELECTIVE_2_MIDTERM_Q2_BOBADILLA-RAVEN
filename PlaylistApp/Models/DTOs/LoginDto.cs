using System.ComponentModel.DataAnnotations;

namespace PlaylistApp.Models.DTOs
{
    public class LoginDto
    {
        [Required(ErrorMessage = "USERNAME IS REQUIRED.")]
        public string Username { get; set; } = "";

        [Required(ErrorMessage = "PASSWORD IS REQUIRED.")]
        public string Password { get; set; } = "";
    }
}