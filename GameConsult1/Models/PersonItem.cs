using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameConsult1.Models
{
    public class PersonItem:BaseEntity
    {
        public int? PersonId { get; set; }
        public Person Person { get; set; }

        public int? ItemId { get; set; }
        public Item Item { get; set; }
    }
}