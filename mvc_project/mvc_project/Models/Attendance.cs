using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_project.Models
{
    public class Attendance
    {
        [Key]
        public int AttId { get; set; }
        [ForeignKey("User")]
        public string StdId { get; set; }

        public ApplicationUser User { get; set; }

        public string AttDate { get; set; }
        public string TimeAttend { get; set; }
        public string TimeLeft { get; set; }
    }
}