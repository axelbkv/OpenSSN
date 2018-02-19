using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Roleapplicationright
    {
        public int Roleapplicationrightid { get; set; }
        public int RoleRoleid { get; set; }
        public int ApplicationrightApplicationrightid { get; set; }

        public Applicationright ApplicationrightApplicationright { get; set; }
        public Role RoleRole { get; set; }
    }
}
