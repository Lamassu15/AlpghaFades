using System;

namespace AlpghaFades.Server.Models;

public class Barber
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }

    // Relations
    public ICollection<Service> Services { get; set; } = new List<Service>();
    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
