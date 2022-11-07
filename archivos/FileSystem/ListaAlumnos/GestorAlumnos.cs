using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAlumnos
{
    public class GestorAlumnos
    {
        string archivo = "alumnos.txt";

        public void Alta(Alumno unAlumno)
        {
            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            using(StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(unAlumno.GenerarRegistro());
            }
            fs.Close();
        }

        public void Baja(long Dni)
        {
            string output = string.Empty;
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();

                while(linea != null)
                {
                    Alumno unAlumno = new Alumno(linea);
                    if (unAlumno.Dni != Dni) output += linea + Environment.NewLine;
                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            fs = new FileStream(archivo, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(output);
            }
            fs.Close();
        }

        public List<Alumno> Lista()
        {
            List<Alumno> lista = new List<Alumno>();

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Alumno unAlumno = new Alumno(linea);
                    lista.Add(unAlumno);
                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            return lista;
        }
    }
}
