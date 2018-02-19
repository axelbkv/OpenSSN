using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Applicationperson
    {
        public Applicationperson()
        {
            Applicationpersonhistory = new HashSet<Applicationpersonhistory>();
        }

        public int Applicationpersonid { get; set; }
        public int PersonPersonid { get; set; }
        public int ApplicationApplicationid { get; set; }

        public Application ApplicationApplication { get; set; }
        public Person PersonPerson { get; set; }
        public ICollection<Applicationpersonhistory> Applicationpersonhistory { get; set; }
    }
}
