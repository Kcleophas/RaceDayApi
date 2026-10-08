using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceDay.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }

        [Required]
        [StringLength(100)]
        public string EventName { get; set; } = string.Empty;

        [Required]
        public DateTime EventDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal DistanceKm { get; set; }

        [Required]
        [StringLength(50)]
        public string EventType { get; set; } = string.Empty;

        // Organiser who created the event
        [ForeignKey("User")]
        public int UserID { get; set; }

        public virtual User? User { get; set; }

        // Navigation Properties
        public virtual ICollection<Category>? Categories { get; set; }

        public virtual ICollection<Enrolment>? Enrolments { get; set; }
    }
}