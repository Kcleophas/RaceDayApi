using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceDay.Api.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }

        [Required]
        public string EventName { get; set; } = string.Empty;

        public DateTime EventDate { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public double DistanceKm { get; set; }

        public string EventType { get; set; } = string.Empty;
    }
}