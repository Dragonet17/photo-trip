using System;
namespace PhotoTrip.Entities
{
    public class Photo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
