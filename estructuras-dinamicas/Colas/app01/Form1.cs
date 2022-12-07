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

/* Consigna: En un natatorio se tiene una cola para la revisación médica para ingresar a una pileta, es por esto
            que se ordena dividir la cola en una de hombres y una de mujeres.
            Mostrar la cola inicial y las 2 nuevas generadas luego de la separación por sexos. 
 */

namespace app01
{
    public partial class Form1 : Form
    {
        Cola general;
        Cola hombres;
        Cola mujeres;

        public Form1()
        {
            InitializeComponent();
            general = new Cola();
            hombres = new Cola();
            mujeres = new Cola();
        }

        private void printQueue1(Paciente somePaciente)
        {
            ListViewItem paciente = new ListViewItem(somePaciente.id);
            paciente.SubItems.Add(somePaciente.genre);
            listView1.Items.Add(paciente);
            if(somePaciente.Siguiente != null) printQueue1(somePaciente.Siguiente);
        }

        private void printQueue2(Paciente somePaciente)
        {
            ListViewItem paciente = new ListViewItem(somePaciente.id);
            paciente.SubItems.Add(somePaciente.genre);
            listView2.Items.Add(paciente);
            if (somePaciente.Siguiente != null) printQueue2(somePaciente.Siguiente);
        }

        private void printQueue3(Paciente somePaciente)
        {
            ListViewItem paciente = new ListViewItem(somePaciente.id);
            paciente.SubItems.Add(somePaciente.genre);
            listView3.Items.Add(paciente);
            if (somePaciente.Siguiente != null) printQueue3(somePaciente.Siguiente);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente newPaciente = new Paciente()
                {
                    id = Interaction.InputBox("Ingrese el ID del paciente:"),
                    genre = Interaction.InputBox("Ingrese el genero (M = masculino, F = femenino):")
                };

                general.enqueue(newPaciente);
                listView1.Items.Clear();
                printQueue1(general.getFirstOne());
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente dequeuedPaciente = general.dequeue();
                while(dequeuedPaciente != null)
                {
                    if(dequeuedPaciente.genre == "M") hombres.enqueue(dequeuedPaciente);
                    else if(dequeuedPaciente.genre == "F") mujeres.enqueue(dequeuedPaciente);
                    dequeuedPaciente = general.dequeue();
                }
                listView2.Items.Clear();
                listView3.Items.Clear();
                printQueue2(hombres.getFirstOne());
                printQueue3(mujeres.getFirstOne());

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
