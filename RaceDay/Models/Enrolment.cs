using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceDay.Models
{
    public class Enrolment
    {
        [Key]
        public int EnrolmentID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        [ForeignKey("Event")]
        public int EventID { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }

        [Required]
        public DateTime EnrolmentDate { get; set; }

        // Navigation Properties
        public virtual User? User { get; set; }

        public virtual Event? Event { get; set; }

        public virtual Category? Category { get; set; }

        public virtual Result? Result { get; set; }
    }
}