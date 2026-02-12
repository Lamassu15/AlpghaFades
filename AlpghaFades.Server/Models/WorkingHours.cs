using System;

namespace AlpghaFades.Server.Models;

public class WorkingHours
{
    public int Id { get; set; }

    public int BarberId { get; set; }
    public Barber Barber { get; set; } = null!;

    public DayOfWeek Day { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
}
