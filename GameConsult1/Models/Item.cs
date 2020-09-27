using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameConsult1.Models
{
    [KnownType(typeof(Item))]
    public class Item : BaseEntity
    {
        public string Title { get; set; }
        public bool Equipment { get; set; }
        public int Price { get; set; }
    
        //многие ко многим
        public Item()
        {
            People = new List<Person>();
        }

        [JsonIgnore]
        public virtual ICollection<Person> People { get; set; }

    }
}