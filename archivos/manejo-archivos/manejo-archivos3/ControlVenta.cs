using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_archivos3
{
    public class ControlVenta
    {
        string fileURL = "ventas.txt";

        public void add(string newVenta)
        {
            FileStream fs = new FileStream(fileURL, FileMode.Append, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(newVenta);
            }
            fs.Close();
        }

        public void delete(string id)
        {
            string newData = string.Empty;

            FileStream fs = new FileStream(fileURL, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Venta someVenta = new Venta(line);
                    if (someVenta.ID != id) newData += line + Environment.NewLine;
                    line = sr.ReadLine();
                }
            }
            fs.Close();

            fs = new FileStream(fileURL, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(newData);
            }
            fs.Close();
        }

        public void update(string id, string updatedVenta)
        {
            string newData = string.Empty;

            FileStream fs = new FileStream(fileURL, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Venta someVenta = new Venta(line);
                    if (someVenta.ID != id) newData += line + Environment.NewLine;
                    line = sr.ReadLine();
                }
            }
            fs.Close();

            newData += updatedVenta + Environment.NewLine;

            fs = new FileStream(fileURL, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(newData);
            }
            fs.Close();
        }

        public List<Venta> createList()
        {
            List<Venta> newList = new List<Venta>();

            FileStream fs = new FileStream(fileURL, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Venta someVenta = new Venta(line);
                    newList.Add(someVenta);
                    line = sr.ReadLine();
                }
            }

            return newList;
        }

        public void orderListById()
        {
            List<Venta> disorderList = createList();
            List<Venta> ordenedList = disorderList.OrderBy(venta => venta.ID).ToList();
            string newData = string.Empty;

            foreach (Venta item in ordenedList)
            {
                newData += item.getString() + Environment.NewLine;
            }

            FileStream fs = new FileStream(fileURL, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(newData);
            }
            fs.Close();
        }

        public void orderListByMonto()
        {
            List<Venta> disorderList = createList();
            List<Venta> ordenedList = disorderList.OrderBy(venta => venta.Monto).ToList();
            string newData = string.Empty;

            foreach (Venta item in ordenedList)
            {
                newData += item.getString() + Environment.NewLine;
            }

            FileStream fs = new FileStream(fileURL, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(newData);
            }
            fs.Close();
        }
    }
}
