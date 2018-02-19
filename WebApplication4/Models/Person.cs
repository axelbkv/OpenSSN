using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Person
    {
        public Person()
        {
            Applicationperson = new HashSet<Applicationperson>();
            Personrole = new HashSet<Personrole>();
        }

        public int Personid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public ICollection<Applicationperson> Applicationperson { get; set; }
        public ICollection<Personrole> Personrole { get; set; }
    }
}
