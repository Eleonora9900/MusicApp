using System;
using MusicApp_DL.Interfaces;
using MusicApp_DL.MemoryDB;
using MusicApp_Models.Models;

namespace MusicApp_DL.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        public void Add(Artist artist)
        {
            InMemoryDB.ArtistsData.Add(artist);
        }

        public void Delete(int id)
        {
            var artist = GetById(id);
            if (artist != null)
            {
                InMemoryDB.ArtistsData.Remove(artist);
            }
        }

        public List<Artist> GetAll()
        {
            return InMemoryDB.ArtistsData;
        }

        public Artist GetById(int id)
        {
            return InMemoryDB.ArtistsData.FirstOrDefault(artist => artist.Id == id);
        }
    }
}

