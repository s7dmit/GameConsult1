using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameConsult1.Models
{
   // [KnownType(typeof(BaseEntity))]

    [Serializable]
    [KnownType(typeof(Spell))]
    [KnownType(typeof(GameSession))]
    [KnownType(typeof(Item))]
    [DataContract(IsReference = true)]
    public class BaseEntity
    {
        public int Id { get; set; }
    }
}