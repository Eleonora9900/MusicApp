using System;
using MusicApp_Models.Models;

namespace MusicApp_Models.Responses
{
	public class GetAllSongsByArtistResponse
	{
		public Artist? Artist { get; set; }
		public List<Song> ?Songs {get; set;}
	}
}

