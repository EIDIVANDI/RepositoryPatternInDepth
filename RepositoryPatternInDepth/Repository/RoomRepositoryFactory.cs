using RepositoryPatternInDepth.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPatternInDepth.Repository
{
    public class RoomRepositoryFactory
    {
        private readonly IBaseRepository<Room> repository;

        public RoomRepositoryFactory(
            IBaseRepository<Room> repo)
        {
            repository = repo;
        }
        public Room Reserve(Room room)
        {
            return repository.Create(room);
        }
    }
}
