using System;
using MusicApp_DL.Interfaces;
using MusicApp_DL.MemoryDB;
using MusicApp_Models.Models;

namespace MusicApp_DL.Repositories
{
    public class SongRepository : ISongRepository
    {
        public void Add(Song song)
        {
            InMemoryDB.SongsData.Add(song);
        }

        public void Delete(Guid id)
        {
            var song = GetById(id);
            if (song != null)
            {
                InMemoryDB.SongsData.Remove(song);
            }
        }

        public List<Song> GetAll()
        {
            return InMemoryDB.SongsData;
        }

        public Song GetById(Guid id)
        {
            return InMemoryDB.SongsData.FirstOrDefault(song => song.Id == id);
        }
    }
}

