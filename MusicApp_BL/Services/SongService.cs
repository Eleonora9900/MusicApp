using System;
using MusicApp_BL.Interfaces;
using MusicApp_DL.Interfaces;
using MusicApp_Models.Models;

namespace MusicApp_BL.Services
{
	public class SongService : ISongService
	{
        private readonly ISongRepository _songRepository;

		public SongService(ISongRepository songRepository)
		{
            _songRepository = songRepository;
		}

        public void AddSong(Song song)
        {
            _songRepository.Add(song);
        }

        public void DeleteSong(int id)
        {
            _songRepository.Delete(id);
        }

        public List<Song> GetAllSongs()
        {
            return _songRepository.GetAll();
        }

        public List<Song> GetAllSongsByArtist(int artistId)
        {
            return _songRepository.GetAllSongsByArtist(artistId);
        }

        public Song GetById(int id)
        {
            return _songRepository.GetById(id);
        }
    }
}

