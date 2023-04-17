using RazorPagesEventMakerApp.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace RazorPagesEventMaker.Models
{
    public class FakeEventRepository
    {
        private List<Event> events { get; }
        public FakeEventRepository()
        {
            events = new List<Event>();
            events.Add(new Event
            {
                Id = 1,
                Name = "Roskilde Festival",
                Description = "A lot of music",
                City = "Roskilde",
                DateTime = new DateTime(2020, 6, 9, 10, 0, 0)
            });
            events.Add(new Event
            {
                Id = 2,
                Name = "CPH Marathon",
                Description = "Many Marathon Runners",
                City = "Copenhagen",
                DateTime = new DateTime(2020, 3, 6, 9, 30, 0)
            });
            events.Add(new Event
            {
                Id = 3,
                Name = "CPH Distorsion",
                Description = "A lot of beers",
                City = "Copenhagen",
                DateTime = new DateTime(2019, 6, 4, 14, 0, 0)
            });
            events.Add(new Event
            {
                Id = 4,
                Name = "Demo Day",
                Description = "Project Presentation",
                City = "Roskilde",
                DateTime = new DateTime(2020, 6, 9, 9, 0, 0)
            });
            events.Add(new Event
            {
                Id = 1,
                Name = "Roskilde Festival",
                Description = "A lot of music",
                City = "Roskilde",
                DateTime = new DateTime(2020, 6, 9, 10, 0, 0)
            });
        }
        public IEnumerable<Event> GetAllEvents()
        { 
            return events.ToList(); 
        }
    }

}
