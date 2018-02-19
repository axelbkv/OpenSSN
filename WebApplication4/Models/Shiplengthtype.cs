using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Shiplengthtype
    {
        public Shiplengthtype()
        {
            Ship = new HashSet<Ship>();
        }

        public int Shiplengthtypeid { get; set; }
        public string Shiplengthtype1 { get; set; }
        public string Systemname { get; set; }
        public string Description { get; set; }

        public ICollection<Ship> Ship { get; set; }
    }
}
