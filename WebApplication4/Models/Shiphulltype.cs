using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Shiphulltype
    {
        public Shiphulltype()
        {
            Ship = new HashSet<Ship>();
        }

        public int Shiphulltypeid { get; set; }
        public string Shiphulltype1 { get; set; }
        public string Systemname { get; set; }
        public string Description { get; set; }

        public ICollection<Ship> Ship { get; set; }
    }
}
