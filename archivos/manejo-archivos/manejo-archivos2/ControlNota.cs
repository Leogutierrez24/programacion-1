using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_archivos2
{
    public class ControlNota
    {
        string urlFile = "notas.txt";

        public void save(string newNota)
        {
            FileStream fs = new FileStream(urlFile, FileMode.Append, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(newNota);
            }
            fs.Close();
        }

        public void delete(long DNI, short nota, DateTime fecha)
        {
            string fileData = string.Empty;

            FileStream fs = new FileStream(urlFile, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Nota someNota = new Nota(line);
                    if (someNota.DNI != DNI && someNota.Calif != nota && someNota.Fecha != fecha) fileData += line + Environment.NewLine;
                    line = sr.ReadLine();
                }
            }
            fs.Close();

            fs = new FileStream(urlFile, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(fileData);
            }
            fs.Close();
        }

        public void update(long DNI, short nota, DateTime fecha, Nota updatedNota)
        {
            string fileData = string.Empty;

            FileStream fs = new FileStream(urlFile, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Nota someNota = new Nota(line);
                    if (someNota.DNI != DNI && someNota.Calif != nota && someNota.Fecha != fecha) fileData += line + Environment.NewLine;
                    line = sr.ReadLine();
                }
            }
            fs.Close();

            fileData += updatedNota.createString() + Environment.NewLine;

            fs = new FileStream(urlFile, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(fileData);
            }
            fs.Close();
        }

        public List<Nota> getListNotas()
        {
            List<Nota> notaList = new List<Nota>();

            FileStream fs = new FileStream(urlFile, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Nota someNota = new Nota(line);
                    notaList.Add(someNota);
                    line = sr.ReadLine();
                }
            }
            fs.Close();

            return notaList;
        }

        public List<Nota> orderById()
        {
            string newFileData = string.Empty;
            List<Nota> disorderList = getListNotas();
            List<Nota> ordenedList = disorderList.OrderBy(nota => nota.DNI).ToList();

            foreach (Nota item in ordenedList)
            {
                newFileData += item.createString() + Environment.NewLine;
            }

            FileStream fs = new FileStream(urlFile, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(newFileData);
            }
            fs.Close();

            return ordenedList;
        }
    }
}
