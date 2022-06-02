using Example6._2._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example6._2._1.Services
{
    public interface ISongsService
    {
        //Create
        Task CreateAsync(Song song);

        //Read
        Task<IEnumerable<Song>> GetAllAsync();

        //Update
        Task UpdateAsync(Song song);

        //Delete
        Task DeleteAsync(int id);
    }
}
