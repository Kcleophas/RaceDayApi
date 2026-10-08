using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceDay.Models
{
    public class Result
    {
        [Key]
        public int ResultID { get; set; }

        [ForeignKey("Enrolment")]
        public int EnrolmentID { get; set; }

        [Required]
        public TimeSpan FinishTime { get; set; }

        [Required]
        public int Position { get; set; }

        // Navigation Property
        public virtual Enrolment? Enrolment { get; set; }
    }
}