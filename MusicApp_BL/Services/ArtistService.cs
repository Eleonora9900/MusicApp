using System;
using MusicApp_BL.Interfaces;
using MusicApp_DL.Interfaces;
using MusicApp_Models.Models;

namespace MusicApp_BL.Services
{
	public class ArtistService : IArtistService
	{
        private readonly IArtistRepository _artistRepository;

		public ArtistService(IArtistRepository artistRepository)
		{
            _artistRepository = artistRepository;
		}

        public void Add(Artist artist)
        {
            _artistRepository.Add(artist);
        }

        public void Delete(int id)
        {
            _artistRepository.Delete(id);
        }

        public List<Artist> GetAll()
        {
            return _artistRepository.GetAll();
        }

        public Artist GetById(int id)
        {
            return _artistRepository.GetById(id);
        }
    }
}

