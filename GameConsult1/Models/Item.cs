using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameConsult1.Models
{
    public class Item : BaseEntity
    {
        public string Title { get; set; }
        public bool Equipment { get; set; }
        public int Price { get; set; }
    
        public Item()
        {
            PersonItems = new List<PersonItem>();
        }
        [JsonIgnore]
        public virtual ICollection<PersonItem> PersonItems { get; set; }

    }
}