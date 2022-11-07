using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaAlumnos
{
    public partial class Form1 : Form
    {
        GestorAlumnos alumnos = new GestorAlumnos();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno((long)numericUpDown1.Value)
            {
                Apellido = textBox2.Text,
                Nombre = textBox1.Text
            };

            alumnos.Alta(alumno);
            LlenarGrilla();
        }

        private void LlenarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alumnos.Lista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                Alumno seleccionado = (Alumno)dataGridView1.SelectedRows[0].DataBoundItem;
                alumnos.Baja(seleccionado.Dni);
                LlenarGrilla();
            }
        }
    }
}
