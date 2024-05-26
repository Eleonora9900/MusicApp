using System;
using MusicApp_BL.Interfaces;
using MusicApp_Models.Models;

namespace MusicApp_BL.Services
{
	public class ArtistService : IArtistService
	{
        private readonly IArtistService _artistService;

		public ArtistService(IArtistService artistService)
		{
            _artistService = artistService;
		}

        public void Add(Artist artist)
        {
            _artistService.Add(artist);
        }

        public void Delete(int id)
        {
            _artistService.Delete(id);
        }

        public List<Artist> GetAll()
        {
            return _artistService.GetAll();
        }

        public Artist GetById(int id)
        {
            return _artistService.GetById(id);
        }
    }
}

