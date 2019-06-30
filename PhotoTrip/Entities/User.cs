using System;
using System.Collections.Generic;

namespace PhotoTrip.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastLogIn { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
