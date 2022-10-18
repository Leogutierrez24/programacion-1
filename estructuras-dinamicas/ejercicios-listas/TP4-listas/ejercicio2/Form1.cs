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
        Lista listaAlumnos;
        public Form1()
        {
            InitializeComponent();
            listaAlumnos = new Lista();
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
                    FechaNac = (dateTimePicker1.Value).ToString(),
                    Direccion = textBox4.Text,
                    Telefono = textBox5.Text,
                };
                listaAlumnos.agregarAlumno(nuevoAlumno);
                MessageBox.Show($"Agregaste a {nuevoAlumno.Nombre} {nuevoAlumno.Apellido} como nuevo alumno!!!");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

    }
}

public class Lista
{
    Alumno Centinela;

    public Lista()
    {
        Centinela = new Alumno();
    }

    public void agregarAlumno(Alumno nuevoAlumno)
    {
        if (Centinela.Siguiente == null) Centinela.Siguiente = nuevoAlumno;
        else ultimoAlumno(Centinela.Siguiente).Siguiente = nuevoAlumno;
    }

    private Alumno ultimoAlumno(Alumno unAlumno)
    {
        Alumno auxAlumno = unAlumno;
        if (unAlumno.Siguiente != null) auxAlumno = ultimoAlumno(unAlumno.Siguiente);
        return auxAlumno;
    }

    public int cantidadAlumnos(Alumno unAlumno, int cantidad)
    {
        int nAlumnos = 5;
        
        return nAlumnos;
    }

}

public class Alumno
{
    public Alumno(string nombre = "", string apellido = "", string dni = "", string fechaNac = "", string direccion = "", string telefono = "")
    {
        Nombre = nombre;
        Apellido = apellido;
        Dni = dni;
        FechaNac = fechaNac;
        Direccion = direccion;
        Telefono = telefono;
        Siguiente = null;
        Anterior = null;
    }

    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Dni { get; set; }
    public string FechaNac { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public Alumno Siguiente { get; set; }
    public Alumno Anterior { get; set; }

}
