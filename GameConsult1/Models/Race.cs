using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameConsult1.Models
{
    public class Race:BaseEntity
    {
        public string Name { get; set; }

        public int? AdditionalSkillId { get; set; }
        public virtual AdditionalSkill AdditionalSkill { get; set; }


        public Race()
        {
            People = new List<Person>();
        }

        [JsonIgnore]
        public virtual ICollection<Person> People { get; set; }
    }
}