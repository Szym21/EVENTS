using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace EventsAPI.Models
{
    public class Event
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey(nameof(EventType))]
        public EventType EVENT_TYPE { get; set; }
        public required DateOnly DATE { get; set; }
        public required TimeOnly TIME { get; set; }
    }
}
