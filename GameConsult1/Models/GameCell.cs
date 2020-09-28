using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameConsult1.Models
{
    //[KnownType(typeof(GameCell))]
    public class GameCell : BaseEntity
    {
        public string Title { get; set; }

        //Связь один ко многим
        public GameCell()
        {
            Players = new List<Player>();
        }
        public DateTime CreationDate { get; set; }

        [JsonIgnore]
        public virtual ICollection<Player> Players { get; set; }

    }
}