using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Location
    {
        public Location()
        {
            InverseLocationLocation = new HashSet<Location>();
        }

        public int Locationid { get; set; }
        public int? LocationLocationid { get; set; }
        public int CountryCountryid { get; set; }

        public Country CountryCountry { get; set; }
        public Location LocationLocation { get; set; }
        public ICollection<Location> InverseLocationLocation { get; set; }
    }
}
