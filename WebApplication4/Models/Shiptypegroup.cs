using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Shiptypegroup
    {
        public Shiptypegroup()
        {
            Shiptype = new HashSet<Shiptype>();
        }

        public int Shiptypegroupid { get; set; }
        public string Shiptypegroupcode { get; set; }
        public string Shiptypegroup1 { get; set; }
        public string Systemname { get; set; }
        public string Description { get; set; }

        public ICollection<Shiptype> Shiptype { get; set; }
    }
}
