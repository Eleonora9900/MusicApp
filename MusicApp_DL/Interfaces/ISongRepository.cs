using System;
using MusicApp_Models.Models;

namespace MusicApp_DL.Interfaces
{
	public interface ISongRepository
	{
		public List<Song> GetAll();
	}
}

