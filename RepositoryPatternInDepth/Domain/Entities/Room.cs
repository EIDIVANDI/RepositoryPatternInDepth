using RepositoryPatternInDepth.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryPatternInDepth.Domain.Entities
{
    public class Room : IBaseEntity
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public byte NumberOfGuests { get; set; }

        public bool Availability { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        internal bool IsValid()
        {
            return true;
        }
    }
}
