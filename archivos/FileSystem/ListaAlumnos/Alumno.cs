namespace ListaAlumnos
{
    public class Alumno
    {
        public Alumno(long dni)
        {
            this.Dni = dni;
        }

        public Alumno(string linea)
        {
            string[] datos = linea.Split(',');
            this.Dni = long.Parse(datos[0]);
            this.Apellido = datos[1];
            this.Nombre = datos[2];
        }

        public long Dni { get; private set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string GenerarRegistro()
        {
            return $"{Dni},{Apellido},{Nombre}";
        }
    }
}
