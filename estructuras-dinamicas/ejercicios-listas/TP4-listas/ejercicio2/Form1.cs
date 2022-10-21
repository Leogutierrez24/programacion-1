using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2
{
    public partial class Form1 : Form
    {
        ListaAlumnos nuevaLista;
        public Form1()
        {
            InitializeComponent();
           nuevaLista = new ListaAlumnos();
        }

        private void button1_Click(object sender, EventArgs e) // Agregar nuevo alumno (último)
        {
            try
            {
                Alumno nuevoAlumno = new Alumno
                {
                    Nombre = textBox1.Text,
                    Apellido = textBox2.Text,
                    Dni = textBox3.Text,
                    FNacimiento = dateTimePicker1.Value.ToShortDateString(),
                    Dir = textBox4.Text,
                    Tel = textBox5.Text
                };
                nuevaLista.AgregarAlumno(nuevoAlumno);
                MessageBox.Show($"Se agrego al alumno {nuevoAlumno.Nombre} {nuevoAlumno.Apellido}");
                clearTextbox();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e) // Imprime la lista 
        {
            try
            {
                listView1.Items.Clear();
                Alumno primerAlumno = nuevaLista.primerAlumno();
                if (primerAlumno == null) MessageBox.Show("No hay ningún alumno para imprimir.");
                else imprimirLista(primerAlumno);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearTextbox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void imprimirLista(Alumno unAlumno)
        {
            ListViewItem itemAlumno = new ListViewItem(unAlumno.Nombre);
            itemAlumno.SubItems.Add(unAlumno.Apellido);
            itemAlumno.SubItems.Add(unAlumno.Dni);
            itemAlumno.SubItems.Add(unAlumno.FNacimiento);
            itemAlumno.SubItems.Add(unAlumno.Dir);
            itemAlumno.SubItems.Add(unAlumno.Tel);
            listView1.Items.Add(itemAlumno);
            if (unAlumno.Siguiente != null) imprimirLista(unAlumno.Siguiente);
        }
    }
}

public class ListaAlumnos
{
    Alumno Puntero;
    public ListaAlumnos()
    {
        Puntero = new Alumno();
    }

    public void AgregarAlumno(Alumno nuevoAlumno)
    {
        if (Puntero.Siguiente == null) Puntero.Siguiente = nuevoAlumno;
        else ultimoAlumno(Puntero.Siguiente).Siguiente = nuevoAlumno;
    }

    public Alumno ultimoAlumno(Alumno unAlumno)
    {
        Alumno elUltimo = unAlumno;
        if (unAlumno.Siguiente != null) ultimoAlumno(unAlumno.Siguiente);
        return elUltimo;
    }

    public Alumno primerAlumno()
    {
        Alumno elPrimero = null;
        if (Puntero.Siguiente == null) return elPrimero;
        else
        {
            elPrimero = Puntero.Siguiente;
            return elPrimero;
        }
    }
}

public class Alumno
{
    public Alumno(string nombre = "", string apellido = "", string dni = "", string fNacimiento = "", string dir = "", string tel = "")
    {
        Nombre = nombre;
        Apellido = apellido;
        Dni = dni;
        FNacimiento = fNacimiento;
        Dir = dir;
        Tel = tel;
        Anterior = null;
        Siguiente = null;
    }

    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Dni { get; set; }
    public string FNacimiento { get; set; }
    public string Dir { get; set; }
    public string Tel { get; set; }
    public Alumno Anterior { get; set; }
    public Alumno Siguiente { get; set; }
}