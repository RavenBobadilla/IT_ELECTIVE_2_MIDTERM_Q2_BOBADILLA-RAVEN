using PlaylistApp.Models.Entities;

namespace PlaylistApp.Data
{
    public static class MockDatabase
    {
        public static List<Playlist> Playlists { get; set; } = new List<Playlist>();
    }
}