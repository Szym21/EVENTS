using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace EventsAPI.Models
{
    [Table("User", Schema = "Events")]
    public class User
    {
        public int ID { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? FIRST_NAME { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? LAST_NAME { get; set; }

        [Column(TypeName = "varchar(50)")]
        public required string EMAIL { get; set; }

        [Column(TypeName = "varchar(50)")]
        public required string PASSWORD { get; set; }

        [Column(TypeName = "varchar(50)")]
        public required string ROLE { get; set; }
    }
}
