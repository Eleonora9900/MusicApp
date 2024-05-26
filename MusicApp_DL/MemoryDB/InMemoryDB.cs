using System;
using MusicApp_Models.Models;

namespace MusicApp_DL.MemoryDB
{
	public static class InMemoryDB
	{
		public static List<Song> SongsData = new()
		{
			new Song()
			{
				Id = 11,
				Title = "Song 1",
				ArtistId = 1,
				AlbumId = 21,
				Genre = "Soundtrack",
				ReleaseDate = new DateTime(2020, 12, 15)
			},
			new Song()
			{
				Id = 12,
				Title = "Song 2",
				ArtistId = 2,
				AlbumId = 32,
				Genre = "Pop",
				ReleaseDate = new DateTime(2023, 7, 9)
			},
			new Song()
			{
				Id = 13,
				Title = "Song 3",
				ArtistId = 3,
				AlbumId = 55,
				Genre = "Electronic",
				ReleaseDate = new DateTime(2023, 12, 2)
			}
		};

		public static List<Artist> ArtistsData = new()
		{
			new Artist()
			{
				Id = 1,
				Name = "Weekend"
			},
			new Artist()
			{
				Id = 2,
				Name = "B.Poarch"
			},
			new Artist()
			{
				Id = 3,
				Name = "M.I.A."
			}
		};

		public static List<Album> AlbumsData = new()
		{
			new Album()
			{
				Id = 21,
				Title = "Album 1",
				ArtistName = "Weekend"
            },
			new Album()
			{
				Id = 32,
				Title = "Album 2",
				ArtistName = "B.Poarch"
            },
			new Album()
			{
				Id = 55,
				Title = "Album 3",
				ArtistName = "M.I.A."
            }
		};
	}

}

