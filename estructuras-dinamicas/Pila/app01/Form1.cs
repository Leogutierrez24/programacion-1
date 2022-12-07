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

/* Consigna: Un almacén tiene capacidad para apilar n contenedores. Cada contenedor tiene un número de
        identificación. Cuando se desea retirar un contenedor específico, deben retirarse primero los
        contenedores que están encima de él y colocarlos en otra pila, efectuar el retiro y regresarlos.
        Codifique los métodos Push ( ) y Pop ( ) para gestionar los contenedores.
 */

namespace app01
{
    public partial class Form1 : Form
    {
        Pila pilaContenedores;
        public Form1()
        {
            InitializeComponent();
            pilaContenedores = new Pila();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                Contenedor newContenedor = new Contenedor(Interaction.InputBox("Ingrese el ID:"));
                pilaContenedores.push(newContenedor);
                printPila(pilaContenedores.getLastOne());
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printPila(Contenedor unContenedor)
        {
            if(unContenedor != null)
            {
                listView1.Items.Add(unContenedor.Id);
                if (unContenedor.Siguiente != null) printPila(unContenedor.Siguiente);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                pilaContenedores.pop();
                listView1.Items.Clear();
                printPila(pilaContenedores.getLastOne());
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
