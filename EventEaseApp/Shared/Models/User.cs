namespace EventEaseApp.Shared.Models;

public class User
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }

    // Providing a default constructor to ensure required properties are set
    public User() {}

    // Parameterized constructor for initialization
    public User(string username, string email)
    {
        Username = username;
        Email = email;
    }
}
