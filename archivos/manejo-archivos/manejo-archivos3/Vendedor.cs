using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_archivos3
{
    public class Vendedor
    {
        public Vendedor(string vendedorData)
        {
            string[] data = vendedorData.Split(',');
            this.ID = data[0];
            this.Nombre = data[1];
        }

        public string getString()
        {
            return $"{this.ID},{this.Nombre}";
        }

        public string ID { get; set; }
        public string Nombre { get; set; }
    }
}
