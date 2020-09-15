using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameConsult1.Models
{
    public class GameSessionPlayer:BaseEntity
    {
        public int? PersonId { get; set; }
        public Person Person { get; set; }

        public int? GameSessionId { get; set; }
        public GameSession GameSession { get; set; }
    }
}