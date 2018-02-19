using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Application
    {
        public Application()
        {
            Applicationperson = new HashSet<Applicationperson>();
        }

        public int Applicationid { get; set; }
        public int ApplicationrightApplicationrightid { get; set; }

        public Applicationright ApplicationrightApplicationright { get; set; }
        public ICollection<Applicationperson> Applicationperson { get; set; }
    }
}
