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

namespace pilas
{
    public partial class Form1 : Form
    {
        Pila pila01;
        public Form1()
        {
            InitializeComponent();
            pila01 = new Pila();
        }

        private void button1_Click(object sender, EventArgs e) // button para apilar
        {
            try
            {
                pila01.Apilar(Interaction.InputBox("Ingrese el id: "));
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) // button para desapilar
        {
            try
            {
                Nodo nodoDesapilado = pila01.Desapilar();
                MessageBox.Show($"{(nodoDesapilado == null ? "No hay nodos para desapilar!!!" : "Se desapilo el nodo de id: " + nodoDesapilado.Id)}");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Nodo toShowNodo = pila01.Ver();
                MessageBox.Show($"{(toShowNodo == null ? "No hay nodos para mostrar" : toShowNodo.Id)}");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class Pila
    {
        Nodo Centinela;
        public Pila()
        {
            Centinela = new Nodo();
        }

        public void Apilar(string Id)
        {
            Nodo auxNodo = new Nodo(Id); // nodo auxiliar
            if(Centinela.Siguiente == null) Centinela.Siguiente = auxNodo; // si el centinella apunta a null (quiere decir que la pila esta vacía), ahora apunta al nodo aux
            else
            { 
                auxNodo.Siguiente = Centinela.Siguiente; // si no esta vacía, el auxiliar va a apuntar al nodo que apunta el centinela
                Centinela.Siguiente = auxNodo; // y el centinela va a apuntar al nuevo nodo
            }
        }

        public Nodo Desapilar()
        {
            Nodo auxNodo = null; // nodo auxiliar
            if(Centinela.Siguiente != null) // si el centinela no apunta a null quiere decir que hay nodos
            {
                auxNodo = Centinela.Siguiente; // el nodo auxiliar es el nodo al que apunta el centinela
                Centinela.Siguiente = auxNodo.Siguiente; // ahora el centinela apunta al siguiente nodo (que apunta el nodo auxiliar)
                auxNodo.Siguiente = null; // ahora el nodo auxiliar (el último nodo de la fila) no forma parte de la pila, es decir apunta a null
            }
            return auxNodo; // retorno el nodo desapilado
        }

        public Nodo Ver()
        {
            Nodo auxNodo = Centinela.Siguiente == null ? null : new Nodo(Centinela.Siguiente.Id); // si el centinela no apunta a nada, es null sino que sea igual a quien apunta el centinela
            return auxNodo; // devuelve el auxiliar, que es igual al último nodo de la pila
        }
    }

    public class Nodo
    {
        public Nodo(string id = "")
        {
            Siguiente = null;
            Id = id;
        }

        public string Id { get; set; }

        public Nodo Siguiente { get; set; }
    }
}
