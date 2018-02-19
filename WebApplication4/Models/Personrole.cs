using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Personrole
    {
        public int Personroleid { get; set; }
        public int PersonPersonid { get; set; }
        public int RoleRoleid { get; set; }

        public Person PersonPerson { get; set; }
        public Role RoleRole { get; set; }
    }
}
