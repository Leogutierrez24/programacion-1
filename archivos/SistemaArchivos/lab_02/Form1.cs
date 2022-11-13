using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_02
{
    public partial class Form1 : Form
    {
        ControlEmpleados empleados = new ControlEmpleados();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImprimirTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datos = $"{numericUpDown1.Value},{textBox1.Text},{textBox2.Text},{textBox3.Text}";
            Empleado nuevoEmpleado = new Empleado(datos);
            empleados.Alta(nuevoEmpleado);
            ImprimirTabla();
            ResetAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1) {
                Empleado seleccionado = (Empleado)dataGridView1.SelectedRows[0].DataBoundItem;
                empleados.Baja(seleccionado.Id);
                ImprimirTabla();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Empleado seleccionado = (Empleado)dataGridView1.SelectedRows[0].DataBoundItem;
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") MessageBox.Show("Por favor, completa los campos para seguir!!!");
                else
                {
                    empleados.Modificar(seleccionado.Id, textBox1.Text, textBox2.Text, textBox3.Text);
                    ImprimirTabla();
                    ResetAll();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            empleados.Ordenar();
            ImprimirTabla();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            decimal totalVendedor = 0;
            decimal totalFinal = 0;

            FileStream file = new FileStream("empleados.txt", FileMode.Open, FileAccess.Read);
            using(StreamReader reader = new StreamReader(file))
            {
                string line = reader.ReadLine();
                string[] datos = line.Split(',');

                while(line != null)
                {
                    string empleadoId = datos[0];
                    dataGridView2.Rows.Add(new string[] { datos[0] });
                    while(empleadoId == datos[0] && line != null)
                    {
                        totalVendedor += decimal.Parse(datos[3]);
                        totalFinal += decimal.Parse(datos[3]);
                        line = reader.ReadLine();
                        if (line != null) datos = line.Split(',');
                    }
                    dataGridView2.Rows.Add(new string[] { "", "Subtotal =>", totalVendedor.ToString() });
                    dataGridView2.Rows.Add(1);

                    totalVendedor = 0;
                    totalVendedor = 0;
                }

                dataGridView2.Rows.Add(1);
                dataGridView2.Rows.Add(new string[] {"", "Total Final => ", totalFinal.ToString() }); ;

                totalFinal = 0;
            }
        }

        private void ImprimirTabla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empleados.GenerarLista();
        }

        private void ResetAll()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            numericUpDown1.Value = 1;
        }

        
    }
}
