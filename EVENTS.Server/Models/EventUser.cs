using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventsAPI.Models
{
    [Table("EventUser", Schema = "Events")]
    [Keyless]
    [Index(nameof(USER_ID),nameof(EVENT_ID), IsUnique = true)]
    public class EventUser
    {
        [ForeignKey(nameof(User))]
        public int USER_ID { get; set; }
        public User USER { get; set; }

        [ForeignKey(nameof(Event))]
        public int EVENT_ID { get; set; }
        public Event EVENT { get; set; }
    }
}
