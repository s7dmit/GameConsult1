using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameConsult1.Models
{
    [KnownType(typeof(Class))]
    public class Class:BaseEntity
    {
        public string Name { get; set; }

        public int? BasicSkillId { get; set; }
        public virtual BasicSkill BasicSkill { get; set; }

        
        public Class()
        {
            People = new List<Person>();
        }

        [JsonIgnore]
        public ICollection<Person> People { get; set; }
    }
}