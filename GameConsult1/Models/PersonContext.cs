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

            //Класс контроллера
        public DbSet<Person> People { get; set; } 

        //Находится с Person в связи один ко многим (один класс у многих персонажей)
        public DbSet<Class> Classes { get; set; }

        //Находится с Person в связи один ко многим
        public DbSet<Player> Players { get; set; }

        //Находится с Person в связи один ко многим
        public DbSet<Race> Races { get; set; }
    }
}