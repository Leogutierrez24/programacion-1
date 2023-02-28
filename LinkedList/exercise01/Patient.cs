using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise01
{
    internal class Patient
    {
        public Patient(string Id = "", string Name = "", string Surname = "", string Adress = "", string Phone = "")
        {
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
            this.Adress = Adress;
            this.Phone = Phone;
            this.Next = null;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public Patient Next { get; set; }
       
    }
}
