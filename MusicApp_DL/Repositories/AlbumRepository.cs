using System;
using MusicApp_DL.Interfaces;
using MusicApp_DL.MemoryDB;
using MusicApp_Models.Models;

namespace MusicApp_DL.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        public void Add(Album album)
        {
            InMemoryDB.AlbumsData.Add(album);
        }

        public void Delete(int id)
        {
            var album = GetById(id);
            if (album != null)
            {
                InMemoryDB.AlbumsData.Remove(album);
            }
        }

        public List<Album> GetAll()
        {
            return InMemoryDB.AlbumsData;
        }

        public Album GetById(int id)
        {
            return InMemoryDB.AlbumsData.FirstOrDefault(album => album.Id == id);
        }
    }
}

