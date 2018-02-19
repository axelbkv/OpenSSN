using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Role
    {
        public Role()
        {
            Personrole = new HashSet<Personrole>();
            Roleapplicationright = new HashSet<Roleapplicationright>();
        }

        public int Roleid { get; set; }

        public ICollection<Personrole> Personrole { get; set; }
        public ICollection<Roleapplicationright> Roleapplicationright { get; set; }
    }
}
