using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameConsult1.Models
{
    [KnownType(typeof(Spell))]
    public class Spell : BaseEntity
    {
        public string Title { get; set; }
        public int LevelSpell { get; set; }

        public Spell()
        {
            People = new List<Person>();
        }

        [JsonIgnore]
        public virtual ICollection<Person> People { get; set; }

    }
}