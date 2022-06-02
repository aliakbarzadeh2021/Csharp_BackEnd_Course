using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example5._8._1.Models;

namespace Example5._8._1.Services
{
    public class AnnouncementsService : IAnnouncementsService
    {

        public async Task<IEnumerable<Announcement>> GetAnnouncementsAsync()
        {
            List<Announcement> announcements = new List<Announcement>()
            {
                new Announcement() {Title = "Announcement 1", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc nisl felis, pellentesque quis mauris fermentum, lobortis pretium ante. Cras molestie purus a purus condimentum dictum et at eros."},
                new Announcement() {Title = "Announcement 1", Content = "In non nibh vel est condimentum luctus vitae non nisl. Duis vitae semper sapien. Donec tortor arcu, ultricies eget rhoncus non, placerat in ipsum. Phasellus vitae sapien mollis, sodales elit quis, tempor orci."},
                new Announcement() {Title = "Announcement 1", Content = "Donec vel quam neque. Suspendisse dapibus mi at leo ultrices, vel varius odio posuere."}
            };
            return announcements;
        }
    }
}
