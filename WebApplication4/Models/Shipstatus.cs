using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Shipstatus
    {
        public Shipstatus()
        {
            Ship = new HashSet<Ship>();
        }

        public int Shipstatusid { get; set; }
        public string Shipstatus1 { get; set; }
        public string Systemname { get; set; }
        public string Description { get; set; }

        public ICollection<Ship> Ship { get; set; }
    }
}
