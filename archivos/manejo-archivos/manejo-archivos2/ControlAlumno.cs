using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace manejo_archivos2
{
    public class ControlAlumno
    {
        string urlFile = "alumnos.txt";

        public void save(string newAlumno)
        {
            FileStream fs = new FileStream(urlFile, FileMode.Append, FileAccess.Write);
            using(StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(newAlumno);
            }
            fs.Close();
        }

        public void delete(long DNI)
        {
            string fileData = string.Empty;

            FileStream fs = new FileStream(urlFile, FileMode.OpenOrCreate, FileAccess.Read);
            using(StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Alumno someAlumno = new Alumno(line);
                    if (someAlumno.DNI != DNI) fileData += line + Environment.NewLine;
                    line = sr.ReadLine();
                }
            }
            fs.Close();

            fs = new FileStream(urlFile, FileMode.Truncate, FileAccess.Write);
            using(StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(fileData);
            }
            fs.Close();
        }

        public void update(long DNI, Alumno updatedAlumno)
        {
            string fileData = string.Empty;

            FileStream fs = new FileStream(urlFile, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Alumno someAlumno = new Alumno(line);
                    if (someAlumno.DNI != DNI) fileData += line + Environment.NewLine;
                    line = sr.ReadLine();
                }
            }
            fs.Close();

            fileData += updatedAlumno.createString() + Environment.NewLine;

            fs = new FileStream(urlFile, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(fileData);
            }
            fs.Close();
        }

        public List<Alumno> getListAlumnos()
        {
            List<Alumno> alumnoList = new List<Alumno>();
            FileStream fs = new FileStream(urlFile, FileMode.OpenOrCreate, FileAccess.Read);
            using(StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();
                while(line != null)
                {
                    Alumno someAlumno = new Alumno(line);
                    alumnoList.Add(someAlumno);
                    line = sr.ReadLine();
                }
            }
            fs.Close();

            return alumnoList;
        }

        public List<Alumno> orderById()
        {
            string newFileData = string.Empty;
            List<Alumno> disorderList = getListAlumnos();
            List<Alumno> ordenedList = disorderList.OrderBy(alumno => alumno.DNI).ToList();

            foreach(Alumno item in ordenedList)
            {
                newFileData += item.createString() + Environment.NewLine;
            }

            FileStream fs = new FileStream(urlFile, FileMode.Truncate, FileAccess.Write);
            using(StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(newFileData);
            }
            fs.Close();

            return ordenedList;
        }
    }
}
