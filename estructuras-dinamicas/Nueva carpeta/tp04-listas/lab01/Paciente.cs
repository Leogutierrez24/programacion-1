using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    public class Paciente
    {
        public Paciente(string cod = "", string name = "", string surname = "" , string dir = "", string phone = "")
        {
            this.Cod = cod;
            this.Name = name;
            this.Surname = surname;
            this.Dir = dir;
            this.Phone = phone;
            this.Siguiente = null;
        }

        public string Cod { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Dir { get; set; }
        public string Phone { get; set; }
        public Paciente Siguiente { get; set; }
    }
}
