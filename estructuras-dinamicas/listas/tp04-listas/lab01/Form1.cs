using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Consigna: Se tiene una lista de pacientes de un hospital y se desea realizar un sistema sobre registro de los
            mismos.
            Los datos de los pacientes son código, nombres, apellido, dirección y teléfono.
            El sistema debe permitir:
            a. Registrar un nuevo paciente
            b. Eliminar paciente (en cualquier posición)
            c. Actualizar Pacientes (modificar algún dato)
            d. Agregar después del seleccionado.
            e. Mostrar Listado
 */

namespace lab01
{
    public partial class Form1 : Form
    {
        Lista listaPacientes;

        public Form1()
        {
            InitializeComponent();
            listaPacientes = new Lista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente newPaciente = new Paciente
                {
                    Name = textBox1.Text,
                    Surname = textBox2.Text,
                    Dir = textBox3.Text,
                    Phone = textBox4.Text,
                    Cod = textBox5.Text,
                };

                listaPacientes.addPaciente(newPaciente);
                dataGridView1.Rows.Clear();
                printList(listaPacientes.getFirst());
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void printList(Paciente unPaciente)
        {
            Paciente pacienteToPrint = unPaciente;
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = pacienteToPrint.Cod;
            dataGridView1.Rows[n].Cells[1].Value = pacienteToPrint.Name;
            dataGridView1.Rows[n].Cells[2].Value = pacienteToPrint.Surname;
            dataGridView1.Rows[n].Cells[3].Value = pacienteToPrint.Dir;
            dataGridView1.Rows[n].Cells[4].Value = pacienteToPrint.Phone;
            if (pacienteToPrint.Siguiente != null) printList(pacienteToPrint.Siguiente);
        }
    }
}
