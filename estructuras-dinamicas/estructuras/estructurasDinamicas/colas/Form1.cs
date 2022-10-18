using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace colas
{
    public partial class Form1 : Form
    {
        Cola cola01;
        public Form1()
        {
            InitializeComponent();
            cola01 = new Cola();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cola01.Encolar(Interaction.InputBox("Ingrese el id del nuevo nodo: "));
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Nodo nodoDesencolado = cola01.Desencolar();
                MessageBox.Show($"{(nodoDesencolado == null ? "No hay nodo a desencolar!!!" : "Se desencolo el nodo con id: " + nodoDesencolado.Id)}");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Nodo nodoaVer = cola01.Ver();
                MessageBox.Show($"{(nodoaVer == null ? "No hay nodos en la cola!!!" : nodoaVer.Id)}");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class Cola 
    {
        Nodo centinela;
        public Cola()
        {
            centinela = new Nodo();
        }

        public void Encolar(string Id)
        {
            Nodo auxNodo = new Nodo(Id);
            if (centinela.Siguiente == null) centinela.Siguiente = auxNodo;
            else
            {
                BuscarUltimoNodo(centinela.Siguiente).Siguiente = auxNodo;
            }
        }

        public Nodo Desencolar()
        {
            Nodo auxNodo = null;
            if(centinela.Siguiente != null)
            {
                auxNodo = centinela.Siguiente;
                centinela.Siguiente = auxNodo.Siguiente;
                auxNodo.Siguiente = null;
            }
            return auxNodo;
        }

        public Nodo Ver()
        {
            Nodo auxNodo = null;
            if(centinela.Siguiente != null)
            {
                auxNodo = new Nodo (centinela.Siguiente.Id);
            }
            return auxNodo;
        }

        private Nodo BuscarUltimoNodo(Nodo randomNodo)
        {
            Nodo auxNodo = randomNodo;
            if (randomNodo.Siguiente != null) auxNodo = BuscarUltimoNodo(randomNodo.Siguiente);
            return auxNodo;
        }           
    }

    public class Nodo
    {
        public Nodo(string id = "")
        {
            Id = id;
            Siguiente = null;
        }

        public string Id { get; set; }
        public Nodo Siguiente { get; set; }
    }
}
