using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manejo_archivos
{
    public partial class Form1 : Form
    {
        Controlador controlAlumnos = new Controlador();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            printList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string alumnoLine = $"{textBox1.Text},{textBox2.Text},{textBox3.Text},{textBox4.Text}";
                Alumno newAlumno = new Alumno(alumnoLine);
                controlAlumnos.alta(newAlumno.generarString());
                clearInput();
                printList();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    Alumno selectedAlumno = (Alumno)dataGridView1.SelectedRows[0].DataBoundItem;
                    controlAlumnos.baja(selectedAlumno.legajo);
                    clearInput();
                    printList();
                }
                else MessageBox.Show("Por favor, selecciona la fila del alumno deseado!!!");

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printList()
        {
            List<Alumno> alumnos = controlAlumnos.createListAlumnos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alumnos;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearInput()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    Alumno prevAlumno = (Alumno)dataGridView1.SelectedRows[0].DataBoundItem;
                    string line = $"{Interaction.InputBox("Nuevo nombre:")},{Interaction.InputBox("Nuevo apellido:")},{Interaction.InputBox("Nuevo legajo:")},{Interaction.InputBox("Nueva categoria:")}";
                    Alumno modifAlumno = new Alumno(line);
                    controlAlumnos.modificar(prevAlumno.legajo, modifAlumno);
                    printList();
                }
                else MessageBox.Show("Por favor, seleccione la fila del alumno a modificar!!!");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
