using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Company
    {
        public Company()
        {
            Ship = new HashSet<Ship>();
        }

        public int Companyid { get; set; }

        public ICollection<Ship> Ship { get; set; }
    }
}
