using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app01
{
    public class Paciente
    {
        public Paciente(string id = "", string genre = "")
        {
            this.id = id;
            this.genre = genre;
            this.Siguiente = null;
        }

        public string id { get; set; }
        public string genre { get; set; }
        public Paciente Siguiente { get; set; }
    }
}
