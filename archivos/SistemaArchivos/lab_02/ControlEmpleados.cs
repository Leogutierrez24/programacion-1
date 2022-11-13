using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    public class ControlEmpleados
    {
        string fileURL = "empleados.txt";

        public void Alta(Empleado unEmpleado)
        {
            FileStream file = new FileStream(fileURL, FileMode.Append, FileAccess.Write);
            using(StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(unEmpleado.GenerarRef());
            }
            file.Close();
        }

        public void Baja(int empleadoID)
        {
            string newData = string.Empty;

            FileStream file = new FileStream(fileURL, FileMode.OpenOrCreate, FileAccess.Read);
            using(StreamReader reader = new StreamReader(file))
            {
                string line = reader.ReadLine();
                while(line != null)
                {
                    Empleado unEmpleado = new Empleado(line);
                    if (unEmpleado.Id != empleadoID) newData += line + Environment.NewLine;
                    line = reader.ReadLine();
                }
            }
            file.Close();

            file = new FileStream(fileURL, FileMode.Truncate, FileAccess.Write);
            using(StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(newData);
            }
            file.Close();
        }

        public void Modificar(int empleadoID, string empleadoNombre, string empleadoApellido, string empleadoVentas)
        {
            string newData = string.Empty;

            FileStream file = new FileStream(fileURL, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(file))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Empleado unEmpleado = new Empleado(line);
                    if (unEmpleado.Id != empleadoID) newData += line + Environment.NewLine;
                    line = reader.ReadLine();
                }
            }
            file.Close();

            Empleado empleadoMod = new Empleado($"{empleadoID},{empleadoNombre},{empleadoApellido},{empleadoVentas}");
            newData += empleadoMod.GenerarRef() + Environment.NewLine;

            file = new FileStream(fileURL, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(newData);
            }
            file.Close();
        }

        public void Ordenar()
        {
            string dataOrdenada = string.Empty;
            List<Empleado> listaEmpleados = new List<Empleado>();

            FileStream file = new FileStream(fileURL, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(file))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Empleado unEmpleado = new Empleado(line);
                    listaEmpleados.Add(unEmpleado);
                    line = reader.ReadLine();
                }
            }
            file.Close();

            List<Empleado> listaOrdenada = listaEmpleados.OrderBy(o => o.Id).ToList();
            foreach(var element in listaOrdenada)
            {
                dataOrdenada += $"{element.Id},{element.Nombre},{element.Apellido},{element.Ventas}" + Environment.NewLine;
            }

            file = new FileStream(fileURL, FileMode.Truncate, FileAccess.Write);
            using(StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(dataOrdenada);
            }
            file.Close();
        }

        public List<Empleado> GenerarLista()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();

            FileStream file = new FileStream(fileURL, FileMode.OpenOrCreate, FileAccess.Read);
            using(StreamReader reader = new StreamReader(file))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Empleado unEmpleado = new Empleado(line);
                    listaEmpleados.Add(unEmpleado);
                    line= reader.ReadLine();
                }
            }
            file.Close();

            return listaEmpleados;
        }
    }
}
