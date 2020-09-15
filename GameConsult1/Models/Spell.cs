using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameConsult1.Models
{
    public class Spell : BaseEntity
    {
        public string Title { get; set; }
    public int LevelSpell { get; set; }

public Spell()
        {
            PersonSpells = new List<PersonSpell>();
        }
        [JsonIgnore]
        public virtual ICollection<PersonSpell> PersonSpells { get; set; }

    }
}