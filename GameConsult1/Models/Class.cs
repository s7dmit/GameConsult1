using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameConsult1.Models
{
    public class Class:BaseEntity
    {
        public string Name { get; set; }

        public int? BasicSkillId { get; set; }
        public virtual BasicSkill BasicSkill { get; set; }
    }
}