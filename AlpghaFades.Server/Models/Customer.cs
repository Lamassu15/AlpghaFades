using System;

namespace AlpghaFades.Server.Models;

public class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? Phone { get; set; }

    // Relationer
    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}

