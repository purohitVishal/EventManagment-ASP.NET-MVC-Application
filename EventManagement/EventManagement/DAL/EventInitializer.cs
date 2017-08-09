using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EventManagement.Models;

namespace EventManagement.DAL
{
    public class EventInitializer : System.Data.Entity.DropCreateDatabaseAlways<EventContext>
    {
        protected override void Seed(EventContext context)
        {
            var volunteers = new List<Volunteer>
            {
            new Volunteer{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01"),ContactNo=3126471982,Location="Chicago"}
            
            };

            volunteers.ForEach(s => context.Volunteers.Add(s));
            context.SaveChanges();
            var events = new List<Event>
            {
            new Event{EventID=1050,Name="Beyond Borders: Identities and Perceptions in Today's World",Description="Beyond Borders: Identities and Perceptions in Today's World An exhibition of international photographs submitted from members across the Boston College community.The theme is Beyond Borders and the selected photographs best fit this concept.The exhibit is part of International Education Week, a nationwide initiative with the goal of fostering international education.",StartDate=DateTime.Parse("2016-09-01"),EndDate=DateTime.Parse("2016-12-01")}
           };
            events.ForEach(s => context.Events.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{VolunteerID=1,EventID=1050}
          };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
        }
}