using System.ComponentModel.DataAnnotations;

namespace PlaylistApp.Models.DTOs
{
    public class CreatePlaylistDto
    {
        [Required(ErrorMessage = "PLAYLIST TITLE IS REQUIRED.")]
        public string Title { get; set; } = "";

        public List<CreateVideoDto> Videos { get; set; } = new();
    }
}