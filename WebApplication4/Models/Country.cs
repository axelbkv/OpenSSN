using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Country
    {
        public Country()
        {
            Location = new HashSet<Location>();
            Ship = new HashSet<Ship>();
            Shipflagcode = new HashSet<Shipflagcode>();
            Shipmmsimidicode = new HashSet<Shipmmsimidicode>();
        }

        public int Countryid { get; set; }

        public ICollection<Location> Location { get; set; }
        public ICollection<Ship> Ship { get; set; }
        public ICollection<Shipflagcode> Shipflagcode { get; set; }
        public ICollection<Shipmmsimidicode> Shipmmsimidicode { get; set; }
    }
}
