namespace EventEaseApp.Server.Data;

using Microsoft.EntityFrameworkCore;
using EventEaseApp.Shared.Models;

public class ApplicationDbContext : DbContext
{
    public DbSet<Event> Events { get; set; } = default!;
    public DbSet<User> Users { get; set; } = default!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { }
}
