﻿using System.ComponentModel.DataAnnotations.Schema;

namespace EventsAPI.Models
{
    [Table("EventType", Schema = "Events")]
    public class EventType
    {
        public int ID { get; set; }
        [Column(TypeName = "varchar(200)")]
        public required string NAME { get; set; }
        public int CAPACITY { get; set; }
        public bool ARCHIVE { get; set; }
    }
}