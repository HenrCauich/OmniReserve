using Microsoft.EntityFrameworkCore;
using OmniReserve.Application.Common.Interfaces;
using OmniReserve.Domain.Entities;

namespace OmniReserve.Infrastructure.Persistence.Repositories;

public class ReservationRepository : IReservationRepository
{
    private readonly ApplicationDbContext _context;

    public ReservationRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Reservation?> GetReservationWithDetailsAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsRoomAvailableAsync(Guid roomId, DateTime start, DateTime end)
    {
        throw new NotImplementedException();
    } 
}