using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceDay.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; } = string.Empty;

        [ForeignKey("Event")]
        public int EventID { get; set; }

        // Navigation Properties
        public virtual Event? Event { get; set; }

        public virtual ICollection<Enrolment>? Enrolments { get; set; }
    }
}