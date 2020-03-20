using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_project.Models
{
    public class Permission
    {
        [Key]
        public int PermId { set; get; }
        [ForeignKey("User")]
        public string StdId { get; set; }
        public ApplicationUser User { get; set; }
        public string PermDate { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
    }
}