using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_archivos2
{
    public class Nota
    {
        public Nota(string line)
        {
            string[] data = line.Split(',');
            this.DNI = Convert.ToInt64(data[0]);
            this.Calif = short.Parse(data[1]);
            this.Fecha = Convert.ToDateTime(data[2]);
        }

        public string createString()
        {
            return $"{this.DNI},{this.Calif},{this.Fecha}";
        }

        public long DNI { get; set; }
        public short Calif { get; set; }
        public DateTime Fecha { get; set; }
    }
}
