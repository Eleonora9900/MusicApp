﻿using System;
using MusicApp_Models.Models;

namespace MusicApp_DL.Interfaces
{
	public interface ISongRepository
	{
        List<Song> GetAll();
		Song GetById(Guid id);
		void Add(Song song);
		void Delete(Guid id);
	}
}

