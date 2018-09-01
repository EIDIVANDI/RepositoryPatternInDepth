using RepositoryPatternInDepth.Domain.Entities;

namespace RepositoryPatternInDepth.Repository
{
    public interface IRoomServiceReservationRepository
    {
        bool CancelReservation(int roomid);
        bool CheckRoomAvailability(int roomid);
        Room GetRoom(int roomid);
        Room ReserveRoom(Room room);
    }
}