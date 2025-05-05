using Microsoft.AspNetCore.Mvc;
using EventEaseApp.Shared.Models;
using System.Collections.Generic;
using System.Globalization;

[ApiController]
[Route("api/events")]
public class EventController : ControllerBase
{
    private static readonly List<Event> Events = new List<Event>
    {
        new Event { Id = 1, Name = "Tech Summit", Location = "London", Date = DateTime.ParseExact("2025-06-15", "yyyy-MM-dd", CultureInfo.InvariantCulture) },
        new Event { Id = 2, Name = "AI Conference", Location = "Birmingham", Date = DateTime.ParseExact("2025-08-22", "yyyy-MM-dd", CultureInfo.InvariantCulture) }
    };

    [HttpGet]
    public IActionResult GetEvents()
    {
        return Ok(Events);
    }
}
