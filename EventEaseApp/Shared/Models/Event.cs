namespace EventEaseApp.Shared.Models;

   public class Event
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Location { get; set; }
    public DateTime Date { get; set; }
}


