using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Se tiene una lista de pacientes de un hospital y se desea realizar un sistema sobre registro de los
mismos.
Los datos de los pacientes son código, nombres, apellido, dirección y teléfono.
El sistema debe permitir:
a. Registrar un nuevo paciente
b. Eliminar paciente (en cualquier posición)
c. Actualizar Pacientes (modificar algún dato)
d. Agregar después del seleccionado.
e. Mostrar Listado
 */

namespace exercise01
{
    public partial class Form1 : Form
    {
        List patientList;
        public Form1()
        {
            InitializeComponent();
            patientList = new List();
            GetList();
        }

        private void PrintList(Patient somePatient)
        {
            Patient aux = somePatient;
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = aux.Id;
            dataGridView1.Rows[n].Cells[1].Value = aux.Name;
            dataGridView1.Rows[n].Cells[2].Value = aux.Surname;
            dataGridView1.Rows[n].Cells[3].Value = aux.Adress;
            dataGridView1.Rows[n].Cells[4].Value = aux.Phone;
            if (aux.Next != null) PrintList(aux.Next);
        }

        private void GetList()
        {
            try
            {
                dataGridView1.Rows.Clear();
                Patient firstValue = patientList.GetInitialValue();

                if (firstValue != null) {
                    PrintList(firstValue);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) // Add patient
        {
            try
            {
                Patient newPatient = new Patient
                {
                    Id = textBox1.Text,
                    Name = textBox2.Text,
                    Surname = textBox3.Text,
                    Adress = textBox4.Text,
                    Phone = textBox5.Text,
                };

                patientList.AddPatient(newPatient);
                GetList();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) // delete patient
        {
            try
            {
                string toDeleteId = textBox10.Text;

                Patient deletedPatient = patientList.RemovePatient(toDeleteId);

                MessageBox.Show($"The patient {deletedPatient.Name} {deletedPatient.Surname} has been removed");
                GetList();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e) // Update patient
        {
            try
            {
                string toUpdateId = textBox6.Text;
                int selectedValue = comboBox1.SelectedIndex;
                string toUpdateData = textBox7.Text;

                patientList.UpdatePatient(toUpdateId, selectedValue, toUpdateData);

                MessageBox.Show("Patient updated");
                GetList();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e) // Insert patient
        {
            try
            {
                string patientId = textBox8.Text;
                int newPosition  = Convert.ToInt32(textBox9.Text);

                patientList.InsertPatient(patientId, newPosition);
                MessageBox.Show($"The patient has been inserted in the position: {newPosition}");
                GetList();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
