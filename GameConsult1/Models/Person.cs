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
            GameSessions = new List<GameSession>();
            Spells = new List<Spell>();
            Items = new List<Item>();
        }
        [JsonIgnore]
        public virtual ICollection<GameSession> GameSessions { get; set; }
        [JsonIgnore]
        public virtual ICollection<Spell> Spells { get; set; }
        [JsonIgnore]
        public virtual ICollection<Item> Items {get; set; }

    }
}