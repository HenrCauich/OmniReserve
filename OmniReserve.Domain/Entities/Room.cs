namespace OmniReserve.Domain.Entities;

public class Room
{
    public Guid Id { get; private set; }
    public string RoomNumber { get; private set; } = string.Empty;
    public decimal PricePerNight { get; private set; }
    public RoomType Type { get; private set; }
    
    public ICollection<Reservation> Reservations { get; private set; } = new List<Reservation>();

    public Room(string roomNumber, decimal pricePerNight, RoomType type)
    {
        Id = Guid.NewGuid();
        RoomNumber = roomNumber;
        PricePerNight = pricePerNight;
        Type = type;
    }
}