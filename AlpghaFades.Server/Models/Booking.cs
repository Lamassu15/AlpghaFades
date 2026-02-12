using System;

namespace AlpghaFades.Server.Models;

public class Booking
{
    public int Id { get; set; }

    public int BarberId { get; set; }
    public Barber Barber { get; set; } = null!;

    public int ServiceId { get; set; }
    public Service Service { get; set; } = null!;

    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;

    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    public BookingStatus Status { get; set; } = BookingStatus.Booked;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

public enum BookingStatus
{
    Booked,
    Cancelled
}