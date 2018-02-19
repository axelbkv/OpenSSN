using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Applicationpersonhistory
    {
        public int Applicationpersonhistoryid { get; set; }
        public int ApplicationpersonApplicationpersonid { get; set; }
        public DateTime? Createddate { get; set; }

        public Applicationperson ApplicationpersonApplicationperson { get; set; }
    }
}
