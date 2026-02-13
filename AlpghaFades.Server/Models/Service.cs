namespace AlpghaFades.Server.Models;

public class Service
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required decimal Price { get; set; }
    public required int DurationMinutes { get; set; }

    // Relationships
    public ICollection<Barber> Barbers { get; set; } = new List<Barber>();
    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
