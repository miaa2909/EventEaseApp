using EventEaseApp.Shared.Models;
using System.Collections.Generic;

namespace EventEaseApp.Client.Services
{
    public class AttendanceTracker
    {
        public List<Event> RegisteredEvents { get; set; } = new List<Event>();

        public void RegisterEvent(Event eventToRegister)
        {
            RegisteredEvents.Add(eventToRegister);
        }
    }
}
