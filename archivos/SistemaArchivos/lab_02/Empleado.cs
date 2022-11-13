using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    public class Empleado
    {
        public Empleado(string datosEmpleado)
        {
            string[] datos = datosEmpleado.Split(',');
            this.Id = Int32.Parse(datos[0]);
            this.Nombre = datos[1];
            this.Apellido = datos[2];
            this.Ventas = Decimal.Parse(datos[3]);
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Ventas { get; set; }

        public string GenerarRef()
        {
            return $"{Id},{Nombre},{Apellido},{Ventas}";
        }
    }
}
