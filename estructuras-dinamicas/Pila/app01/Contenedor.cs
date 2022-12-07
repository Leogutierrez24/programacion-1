using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app01
{
    public class Contenedor
    {
        public Contenedor(string id = "")
        {
            this.Id = id;
            this.Siguiente = null;
        }

        public string Id { get; set; }
        public Contenedor Siguiente { get; set; }
    }
}
