using RepositoryPatternInDepth.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPatternInDepth.Repository
{
    public class RoomServiceReservationRepository : IBaseRepository<Room>, IRoomServiceReservationRepository
    {
        private readonly IBaseRepository<Room> repository;

        public RoomServiceReservationRepository(IBaseRepository<Room> repo)
        {
            this.repository = repo;
        }

        public Room ReserveRoom(Room room)
        {
            if (!this.CheckRoomAvailability(room.Id))
                throw new Exception("Room not available");

            var rm = this.GetRoom(room.Id);
            if (rm.NumberOfGuests < room.NumberOfGuests)
                throw new Exception("Room not available");

            var reservation = this.ReserveRoom(room);
            if (reservation == null)
                throw new Exception("An error occured during reservation");

            return reservation;
        }

        public bool CheckRoomAvailability(int roomid)
        {
            throw new NotImplementedException();
        }

        public Room GetRoom(int roomid)
        {
            throw new NotImplementedException();
        }

        public bool CancelReservation(int roomid)
        {
            throw new NotImplementedException();
        }
        #region IRepository implementation
        public Room Create(Room room)
        {
            try
            {

                var reservation = this.ReserveRoom(room);

                var reporesult = repository.Create(reservation);
                if (reporesult == null)
                    throw new Exception("An error occured during reservation");

                return room;
            }
            catch
            {
                this.CancelReservation(room.Id);
                throw;
            }
        }

        public Room Get(int id)
        {
            return this.GetRoom(id);
        }

        public void Update(Room entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            this.CancelReservation(id);
        }

        #endregion
    }
}
