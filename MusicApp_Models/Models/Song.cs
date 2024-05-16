using System;
namespace MusicApp_Models.Models
{
	public class Song
	{
		public Guid Id { get; set; }
		public string Title { get; set; } = String.Empty;
		public int ArtistId { get; set; } 
		public int AlbumId { get; set; }
		public string Genre { get; set; } = String.Empty;
		public DateTime ReleaseDate { get; set; }
	}
}

