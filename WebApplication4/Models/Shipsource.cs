using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Shipsource
    {
        public Shipsource()
        {
            Ship = new HashSet<Ship>();
        }

        public int Shipsourceid { get; set; }
        public string Shipsource1 { get; set; }
        public string Systemname { get; set; }
        public string Description { get; set; }

        public ICollection<Ship> Ship { get; set; }
    }
}
