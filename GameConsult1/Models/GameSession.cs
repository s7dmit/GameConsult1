using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameConsult1.Models
{
    public class GameSession:BaseEntity
    {
        public string Title { get; set; }
        public DateTime DateGame { get; set; }

        public GameSession()
        {
            GameSessionsPlayers = new List<GameSessionPlayer>();
        }
        [JsonIgnore]
        public virtual ICollection<GameSessionPlayer> GameSessionsPlayers { get; set; }

    }
}