using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab_01
{ 
    public partial class Form1 : Form
    {
        RegistroControl alumnos = new RegistroControl();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImprimirLista();
        }

        private void button1_Click(object sender, EventArgs e) // button Alta
        {
            string dataAlumno = $"{textBox1.Text};{textBox2.Text};{textBox3.Text}";
            Alumno nuevoAlumno = new Alumno(dataAlumno);

            alumnos.Alta(nuevoAlumno);
            ImprimirLista();
            resetInputs();
        }

        private void button2_Click(object sender, EventArgs e) // button Baja
        {
            if (textBox1.Text == "") MessageBox.Show("Se necesita un número de legajo válido!!!");
            else alumnos.Baja(textBox1.Text);
            ImprimirLista();
        }

        private void button3_Click(object sender, EventArgs e) // button Modificar
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") MessageBox.Show("Por favor, completa todos los campos");
            else alumnos.Modificar(textBox1.Text, textBox2.Text, textBox3.Text);
            ImprimirLista();
        }

        private void button4_Click(object sender, EventArgs e) // button Salir
        {
            Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void ImprimirLista()
        {
            listBox1.Items.Clear();
            List<Alumno> someList = alumnos.Lista();
            foreach(var element in someList){
                listBox1.Items.Add($"{element.Legajo} {element.NombreApellido} {element.Categoria}");
            }
        }

        private void resetInputs()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

    }

    public class RegistroControl
    {
        string fileURL = "archivo.txt";

        public void Alta(Alumno unAlumno)
        {
            FileStream file = new FileStream(fileURL, FileMode.Append, FileAccess.Write);
            using(StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(unAlumno.GenerarRegistro());
            }
            file.Close();
        }

        public void Baja(string legajo)
        {
            string newData = "";

            FileStream file = new FileStream(fileURL, FileMode.OpenOrCreate, FileAccess.Read);
            using(StreamReader reader = new StreamReader(file))
            {
                string line = reader.ReadLine();
                while(line != null)
                {
                    Alumno unAlumno = new Alumno(line);
                    if (unAlumno.Legajo != legajo) newData += line + Environment.NewLine;
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

        public void Modificar(string legajo, string nombreApellido, string categoria)
        {
            string newData = "";

            FileStream file = new FileStream(fileURL, FileMode.OpenOrCreate, FileAccess.Read);
            using(StreamReader reader = new StreamReader(file))
            {
                string line = reader.ReadLine();
                while(line != null)
                {
                    Alumno unAlumno = new Alumno(line);
                    if(unAlumno.Legajo != legajo) newData += line + Environment.NewLine;
                    line = reader.ReadLine();
                }
                file.Close();
            }

            Alumno alumnoModificado = new Alumno($"{legajo};{nombreApellido};{categoria}");
            newData += alumnoModificado.GenerarRegistro() + Environment.NewLine;

            file = new FileStream(fileURL, FileMode.Truncate, FileAccess.Write);
            using(StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(newData);
            }
            file.Close();
        }

        public List<Alumno> Lista()
        {
            List<Alumno> nuevaLista = new List<Alumno>();

            FileStream file = new FileStream(fileURL, FileMode.OpenOrCreate, FileAccess.Read);
            using(StreamReader reader = new StreamReader(file))
            {
                string line = reader.ReadLine();
                while(line != null)
                {
                    Alumno unAlumno = new Alumno(line);
                    nuevaLista.Add(unAlumno);
                    line = reader.ReadLine();
                }
            }
            file.Close();

            return nuevaLista;
        }
    }
}
