using Microsoft.AspNetCore.Mvc;
using PlaylistApp.Data;
using PlaylistApp.Models.DTOs;
using PlaylistApp.Models.Entities;
using PlaylistApp.Filters;

namespace PlaylistApp.Controllers
{
    [AuthorizeSession]
    public class PlaylistController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Username = HttpContext.Session.GetString("UserSession");
            return View(MockDatabase.Playlists);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreatePlaylistDto());
        }

        [HttpPost]
        public IActionResult Create(CreatePlaylistDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            var playlist = new Playlist
            {
                Title = dto.Title,
                CreatorName = HttpContext.Session.GetString("UserSession") ?? "Unknown",
                Videos = dto.Videos.Select(v => new VideoItem
                {
                    YouTubeUrl = v.YouTubeUrl,
                    TrackNote = v.TrackNote
                }).ToList()
            };

            MockDatabase.Playlists.Add(playlist);
            return RedirectToAction("INDEX");
        }
    }
}
