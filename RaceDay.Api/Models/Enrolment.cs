using System.ComponentModel.DataAnnotations;

namespace RaceDay.Api.Models
{
    public class Enrolment
    {
        [Key]
        public int EnrolmentID { get; set; }

        public int UserID { get; set; }

        public int EventID { get; set; }

        public int CategoryID { get; set; }
    }
}