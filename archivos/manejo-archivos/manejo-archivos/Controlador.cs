using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace manejo_archivos
{
    public class Controlador
    {
        string urlFile = "alumnos.txt";

        public void alta(string line)
        {
            FileStream fs = new FileStream(urlFile, FileMode.Append, FileAccess.Write);
            using(StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(line);
            }
            fs.Close();
        }

        public void baja(string legajo)
        {
            string data = string.Empty;

            FileStream fs = new FileStream(urlFile, FileMode.OpenOrCreate, FileAccess.Read);
            using(StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Alumno checkAlumno = new Alumno(line);
                    if (checkAlumno.legajo != legajo) data += line + Environment.NewLine;
                    line = sr.ReadLine();
                }
            }
            fs.Close();

            fs = new FileStream(urlFile, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(data);
            }
            fs.Close();
        }

        public void modificar(string legajo, Alumno unAlumno)
        {
            string data = string.Empty;

            FileStream fs = new FileStream(urlFile, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Alumno checkAlumno = new Alumno(line);
                    if (checkAlumno.legajo != legajo) data += line + Environment.NewLine;
                    line = sr.ReadLine();
                }
            }
            fs.Close();

            data += unAlumno.generarString() + Environment.NewLine;

            fs = new FileStream(urlFile, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(data);
            }
            fs.Close();
        }

        public List<Alumno> createListAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();

            FileStream fs = new FileStream(urlFile, FileMode.OpenOrCreate, FileAccess.Read);
            using(StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();
                while(line != null)
                {
                    Alumno toAddAlumno = new Alumno(line);
                    alumnos.Add(toAddAlumno);
                    line = sr.ReadLine();
                }
            }
            fs.Close();

            return alumnos;
        }
    }
}
