using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameConsult1.Models
{
    [KnownType(typeof(Player))]
    public class Player:BaseEntity
    {
        public string Name { get; set; }
        public bool Leading { get; set; }

        //один ко многим. 1 игровая ячейка = много игроков
        public int? GameCellId { get; set; }
        public GameCell GameCell { get; set; }

        //один ко многим. 1 игрок = много персонажей
        public Player()
        {
            People = new List<Person>();
        }

        [JsonIgnore]
        public virtual ICollection<Person> People { get; set; }
    }
}