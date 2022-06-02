using Example5._8._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example5._8._1.Services
{
    public interface IAnnouncementsService
    {
        Task<IEnumerable<Announcement>> GetAnnouncementsAsync();
    }
}
