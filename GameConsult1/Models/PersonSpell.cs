using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameConsult1.Models
{
    public class PersonSpell:BaseEntity
    {
        public int? PersonId { get; set; }
        public Person Person { get; set; }

        public int? SpellId { get; set; }
        public Spell Spell { get; set; }
    }
}