namespace OmniReserve.Domain.Entities;

public class Reservation
{
    public Guid Id { get; private set; }
    public Guid RoomId { get; private set; }
    public Guid UserId { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }

    public Room Room { get; private set; } = null!;
    public User User { get; private set; } = null!;

    public Reservation(Guid roomId, Guid userId, DateTime startDate, DateTime endDate)
    {
        Id = Guid.NewGuid();
        RoomId = roomId;
        UserId = userId;
        StartDate = startDate;
        EndDate = endDate;
    }
}