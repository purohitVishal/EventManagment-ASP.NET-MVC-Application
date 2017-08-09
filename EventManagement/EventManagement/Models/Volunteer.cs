using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventManagement.Models
{
    public class Volunteer
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public Int64 ContactNo { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}