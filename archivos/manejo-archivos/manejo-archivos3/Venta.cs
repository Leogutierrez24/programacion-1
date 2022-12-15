using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_archivos3
{
    public class Venta
    {
        public Venta(string ventaData)
        {
            string[] data = ventaData.Split(',');
            this.ID = data[0];
            this.Monto = Convert.ToDecimal(data[1]);
        }

        public string getString()
        {
            return $"{this.ID},{this.Monto}";
        }

        public string ID { get; set; }
        public decimal Monto { get; set; }
    }
}
