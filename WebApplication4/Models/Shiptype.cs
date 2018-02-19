using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Shiptype
    {
        public Shiptype()
        {
            Ship = new HashSet<Ship>();
        }

        public int Shiptypeid { get; set; }
        public int ShiptypegroupShiptypegroupid { get; set; }
        public string Shiptype1 { get; set; }
        public string Systemname { get; set; }
        public string Description { get; set; }

        public Shiptypegroup ShiptypegroupShiptypegroup { get; set; }
        public ICollection<Ship> Ship { get; set; }
    }
}
