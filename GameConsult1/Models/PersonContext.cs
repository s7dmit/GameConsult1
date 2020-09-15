using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameConsult1.Models
{
    public class PersonContext:DbContext
    {
            public DbSet<Person> People { get; set; }

        public System.Data.Entity.DbSet<GameConsult1.Models.Class> Classes { get; set; }

        public System.Data.Entity.DbSet<GameConsult1.Models.Player> Players { get; set; }

        public System.Data.Entity.DbSet<GameConsult1.Models.Race> Races { get; set; }
    }
}