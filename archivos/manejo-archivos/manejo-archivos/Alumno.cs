using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_archivos
{
    public class Alumno
    {
        public Alumno(string line)
        {
            string[] data = line.Split(',');
            this.nombre = data[0];
            this.apellido = data[1];
            this.legajo = data[2];
            this.categoria = data[3];
        }

        public string generarString()
        {
            return $"{this.nombre},{this.apellido},{this.legajo},{this.categoria}";
        }

        public string nombre { get; set; }
        public string apellido { get; set; }
        public string legajo { get; set; }
        public string categoria { get; set; }
    }
}
