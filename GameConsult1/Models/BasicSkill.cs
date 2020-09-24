using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameConsult1.Models
{
    [KnownType(typeof(BasicSkill))]
    public class BasicSkill:BaseEntity
    {
        public string Name { get; set; }
    }
}