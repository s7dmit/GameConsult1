using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameConsult1.Models
{
    public class PersonContext:DbContext
    {
         public PersonContext()
         {
             base.Configuration.ProxyCreationEnabled = false;
            //Configuration.LazyLoadingEnabled = false;
         }

        //public PersonContext() : base("People")
        //{ }

        public DbSet<Person> People { get; set; }

        public DbSet<Class> Classes { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Race> Races { get; set; }
    }
}