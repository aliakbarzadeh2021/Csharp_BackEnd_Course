using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example6._2._1.Models;
using Example6._2._1.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Example6._2._1.Services
{
    public class SongsService : ISongsService
    {
        private AppDbContext _dbContext;

        public SongsService(AppDbContext context)
        {
            _dbContext = context;
        }

        public async Task CreateAsync(Song song)
        {
            _dbContext.Songs.Add(song);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var s = findSong(id);
            _dbContext.Remove(s);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Song>> GetAllAsync()
        {
            return await _dbContext.Songs.ToListAsync();
        }

        public async Task UpdateAsync(Song song)
        {
            var s = await findSong(song.Id);
            Mapper.Map(song, s);
            _dbContext.Update(s);
            await _dbContext.SaveChangesAsync();
        }

        private async Task<Song> findSong(int id)
        {
            var song = await _dbContext.Songs.SingleOrDefaultAsync(s => s.Id == id);
            if(song == null)
            {
                throw new ArgumentException("Song does not exist");
            }
            return song;
        }

    }
}
