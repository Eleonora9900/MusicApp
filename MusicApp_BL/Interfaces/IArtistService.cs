using System;
using MusicApp_Models.Models;

namespace MusicApp_BL.Interfaces
{
	public interface IArtistService
	{
		List<Artist> GetAll();
		Artist GetById(int id);
		void Add(Artist artist);
		void Delete(int id);
	}
}

