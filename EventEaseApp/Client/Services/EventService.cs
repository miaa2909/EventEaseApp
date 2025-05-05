using EventEaseApp.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventEaseApp.Client.Services
{
    public class EventService
    {
        private List<Event> events = new()
        {
            new Event { Id = 1, Name = "Tech Summit", Location = "London", Date = DateTime.Parse("2025-06-15") },
            new Event { Id = 2, Name = "AI Conference", Location = "Birmingham", Date = DateTime.Parse("2025-08-22") }
        };

        public Task<List<Event>> GetEventsAsync() => Task.FromResult(events);
    }
}
