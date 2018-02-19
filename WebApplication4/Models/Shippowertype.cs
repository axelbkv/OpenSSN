using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Shippowertype
    {
        public Shippowertype()
        {
            Ship = new HashSet<Ship>();
        }

        public int Shippowertypeid { get; set; }
        public string Shippowertype1 { get; set; }
        public string Systemname { get; set; }
        public string Description { get; set; }

        public ICollection<Ship> Ship { get; set; }
    }
}
