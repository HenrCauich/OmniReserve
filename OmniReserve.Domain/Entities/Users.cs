namespace OmniReserve.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string Email { get; private set; } = string.Empty;
    public string FullName { get; private set; } = string.Empty;
    
    public ICollection<Reservation> Reservations { get; private set; } = new List<Reservation>();

    public User(string email, string fullName)
    {
        Id = Guid.NewGuid();
        Email = email;
        FullName = fullName;
    }
}