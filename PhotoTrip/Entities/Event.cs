using System;
using System.Collections.Generic;

namespace PhotoTrip.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public User CreatedBy { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}
