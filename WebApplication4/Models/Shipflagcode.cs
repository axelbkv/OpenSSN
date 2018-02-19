using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Shipflagcode
    {
        public Shipflagcode()
        {
            Ship = new HashSet<Ship>();
        }

        public int Shipflagcodeid { get; set; }
        public int CountryCountryid { get; set; }

        public Country CountryCountry { get; set; }
        public ICollection<Ship> Ship { get; set; }
    }
}
