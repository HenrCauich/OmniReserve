using MediatR;
using OmniReserve.Domain.Enums;
using OmniReserve.Domain.Entities;

namespace OmniReserve.Application.Rooms.Commands.CreateRoom;

public record CreateRoomCommand(
    string RoomNumber,
    RoomType Type,
    decimal PricePerNight
) : IRequest<Guid>;
