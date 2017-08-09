using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EventManagement.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EventManagement.DAL
{
    public class EventContext :DbContext
    {
        public EventContext() : base("EventContext")
        {
        }

        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}