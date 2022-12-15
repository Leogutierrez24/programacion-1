using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_archivos3
{
    public class ControlVendedor
    {
        string fileURL = "vendedores.txt";

        public void add(string newVendedor)
        {
            FileStream fs = new FileStream(fileURL, FileMode.Append, FileAccess.Write);
            using(StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(newVendedor);
            }
            fs.Close();
        }

        public void delete(string id)
        {
            string newData = string.Empty;

            FileStream fs = new FileStream(fileURL, FileMode.OpenOrCreate, FileAccess.Read);
            using(StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();
                while(line != null)
                {
                    Vendedor someVendedor = new Vendedor(line);
                    if (someVendedor.ID != id) newData += line + Environment.NewLine;
                    line = sr.ReadLine();
                }
            }
            fs.Close();

            fs = new FileStream(fileURL, FileMode.Truncate, FileAccess.Write);
            using(StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(newData);
            }
            fs.Close();
        }

        public void update(string id, string updatedVendedor)
        {
            string newData = string.Empty;

            FileStream fs = new FileStream(fileURL, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Vendedor someVendedor = new Vendedor(line);
                    if (someVendedor.ID != id) newData += line + Environment.NewLine;
                    line = sr.ReadLine();
                }
            }
            fs.Close();

            newData += updatedVendedor + Environment.NewLine;

            fs = new FileStream(fileURL, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(newData);
            }
            fs.Close();
        }

        public List<Vendedor> createList()
        {
            List<Vendedor> newList = new List<Vendedor>();

            FileStream fs = new FileStream(fileURL, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();
                while(line != null)
                {
                    Vendedor someVendedor = new Vendedor(line);
                    newList.Add(someVendedor);
                    line = sr.ReadLine();
                }
            }

            return newList;
        }

        public void orderListById()
        {
            List<Vendedor> disorderList = createList();
            List<Vendedor> ordenedList = disorderList.OrderBy(vendedor => vendedor.ID).ToList();
            string newData = string.Empty;

            foreach (Vendedor item in ordenedList)
            {
                newData += item.getString() + Environment.NewLine;
            }

            FileStream fs = new FileStream(fileURL, FileMode.Truncate, FileAccess.Write);
            using(StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(newData);
            }
            fs.Close();
        }

        public void orderListByNombre()
        {
            List<Vendedor> disorderList = createList();
            List<Vendedor> ordenedList = disorderList.OrderBy(vendedor => vendedor.Nombre).ToList();
            string newData = string.Empty;

            foreach (Vendedor item in ordenedList)
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
