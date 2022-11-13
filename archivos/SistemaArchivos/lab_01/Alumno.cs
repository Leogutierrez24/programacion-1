using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01
{
    public class Alumno
    {
        public Alumno(string dataAlumno)
        {
            string[] data = dataAlumno.Split(';');
            this.Legajo = data[0];
            this.NombreApellido = data[1];
            this.Categoria = data[2];
        }

        public string GenerarRegistro()
        {
            return $"{Legajo};{NombreApellido};{Categoria}";
        }

        public string Legajo { get; set; }
        public string NombreApellido { get; set; }
        public string Categoria { get; set; }
    }
}
