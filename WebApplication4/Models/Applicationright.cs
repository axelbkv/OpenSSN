using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Applicationright
    {
        public Applicationright()
        {
            Application = new HashSet<Application>();
            Roleapplicationright = new HashSet<Roleapplicationright>();
        }

        public int Applicationrightid { get; set; }

        public ICollection<Application> Application { get; set; }
        public ICollection<Roleapplicationright> Roleapplicationright { get; set; }
    }
}
