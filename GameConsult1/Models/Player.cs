using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameConsult1.Models
{
    public class Player:BaseEntity
    {
        public string Name { get; set; }
        public bool Leading { get; set; }
        public int? GameCellId { get; set; }
        public GameCell GameCell { get; set; }


        public Player()
        {
            People = new List<Person>();
        }

        [JsonIgnore]
        public virtual ICollection<Person> People { get; set; }
    }
}