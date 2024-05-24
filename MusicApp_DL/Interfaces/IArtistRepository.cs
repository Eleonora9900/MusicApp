using System;
using MusicApp_Models.Models;

namespace MusicApp_DL.Interfaces
{
	public interface IArtistRepository
	{
		List<Artist> GetAll();
		Artist GetById(int id);
		void Add(Artist artist);
		void Delete(int id);
    }
}

