using System;
using MusicApp_BL.Interfaces;
using MusicApp_DL.Interfaces;
using MusicApp_Models.Models;

namespace MusicApp_BL.Services
{
	public class AlbumService : IAlbumService
	{
        private readonly IAlbumRepository _albumRepository;

		public AlbumService(IAlbumRepository albumRepository)
		{
            _albumRepository = albumRepository;
		}

        public void AddAlbum(Album album)
        {
            _albumRepository.Add(album);
        }

        public void DeleteAlbum(int id)
        {
            _albumRepository.Delete(id);
        }

        public Album GetAlbumById(int id)
        {
            return _albumRepository.GetById(id);
        }

        public List<Album> GetAllAlbums()
        {
            return _albumRepository.GetAll();
        }
    }
}

