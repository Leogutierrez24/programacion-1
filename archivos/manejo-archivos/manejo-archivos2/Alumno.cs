using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_archivos2
{
    public class Alumno
    {
        public Alumno(string line)
        {
            string[] data = line.Split(',');
            this.DNI = Convert.ToInt64(data[0]);
            this.Nombre = data[1];
            this.Apellido = data[2];
        }

        public string createString()
        {
            return $"{this.DNI},{this.Nombre},{this.Apellido}";
        }

        public long DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;}
    }
}
