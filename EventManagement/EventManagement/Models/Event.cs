using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace EventManagement.Models
{
    public class Event
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventID { get; set; }

        public string Name { get; set; }

        [Required, StringLength(10000), Display(Name = "Event Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }
        

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}