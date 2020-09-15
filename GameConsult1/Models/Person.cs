using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameConsult1.Models
{
    public class Person:BaseEntity
    {
        public int? PlayerId { get; set; }
        public Player Player { get; set; }

        public string Name { get; set; }
        public int Gender { get; set; }

        public int? RaceId { get; set; }
        public virtual Race Race { get; set; }

        public int? ClassId { get; set; }
        public virtual Class Class { get; set; }

        public int Experience { get; set; }
        public int Power { get; set; }
        public int Dexterity { get; set; }
        public int Intellect { get; set; }
        public int Wisdom { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }

        public Person()
        {
            GameSessionsPlayers = new List<GameSessionPlayer>();
            PersonSpells = new List<PersonSpell>();
            PersonItems = new List<PersonItem>();
        }
        [JsonIgnore]
        public virtual ICollection<GameSessionPlayer> GameSessionsPlayers { get; set; }
        [JsonIgnore]
        public virtual ICollection<PersonSpell> PersonSpells { get; set; }
        [JsonIgnore]
        public virtual ICollection<PersonItem> PersonItems {get; set; }

    }
}