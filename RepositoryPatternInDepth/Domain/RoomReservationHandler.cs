using RepositoryPatternInDepth.Domain.Entities;
using RepositoryPatternInDepth.Repository;
using System;
using System.Linq;

namespace RepositoryPatternInDepth.Domain
{
    public class RoomReservationHandler
    {
        private readonly RoomRepositoryFactory repository;

        public RoomReservationHandler(
            RoomRepositoryFactory repo)
        {
            this.repository = repo;
        }

        public void ReserveRoom(Room room)
        {
            if (room == null)
                throw new ArgumentNullException(nameof(room));

            if (room.IsValid())
            {
                repository.Reserve(room);
            }
        }
    }
}
