using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Shipbreadthtype
    {
        public Shipbreadthtype()
        {
            Ship = new HashSet<Ship>();
        }

        public int Shipbreadthtypeid { get; set; }
        public string Shipbreadthtype1 { get; set; }
        public string Systemname { get; set; }
        public string Description { get; set; }

        public ICollection<Ship> Ship { get; set; }
    }
}
