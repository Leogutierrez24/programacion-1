using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manejo_archivos3
{
    public partial class Form1 : Form
    {
        ControlVendedor controlVendedores;
        ControlVenta controlVentas;

        public Form1()
        {
            InitializeComponent();
            controlVendedores = new ControlVendedor();
            controlVentas = new ControlVenta();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            printVendedores();
            printVentas();
        }

        public void printVendedores()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controlVendedores.createList();
        }

        public void printVentas()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = controlVentas.createList();
        }

        public void clearInputsVendedor()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        public void clearInputsVentas()
        {
            textBox3.Text = string.Empty;
            numericUpDown1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e) // add vendedor
        {
            try
            {
                Vendedor newVendedor = new Vendedor($"{textBox1.Text},{textBox2.Text}");
                controlVendedores.add(newVendedor.getString());
                clearInputsVendedor();
                printVendedores();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) // delete vendedor
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    Vendedor toDelete = (Vendedor)dataGridView1.SelectedRows[0].DataBoundItem;
                    controlVendedores.delete(toDelete.ID);
                    clearInputsVendedor();
                    printVendedores();
                }
                else MessageBox.Show("Elige la fila del vendedor a eliminar!!!");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e) // update vendedor
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    if(textBox1.Text != "" && textBox2.Text != "")
                    {
                        Vendedor toUpdate = (Vendedor)dataGridView1.SelectedRows[0].DataBoundItem;
                        Vendedor updatedVendedor = new Vendedor($"{textBox1.Text},{textBox2.Text}");
                        controlVendedores.update(toUpdate.ID, updatedVendedor.getString());
                        clearInputsVendedor();
                        printVendedores();
                    } else
                    {
                        MessageBox.Show("Completa los campos para proceder!!!");
                        textBox1.Focus();
                    }
                }
                else MessageBox.Show("Elige la fila del vendedor a modificar!!!");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) controlVendedores.orderListById();
            else if (radioButton2.Checked) controlVendedores.orderListByNombre();
            else MessageBox.Show("Debe seleccionar una opción para ordenar!!!");
            printVendedores();
        }

        private void button6_Click(object sender, EventArgs e) // add venta
        {
            try
            {
                Venta newVenta = new Venta($"{textBox3.Text},{numericUpDown1.Value}");
                controlVentas.add(newVenta.getString());
                clearInputsVentas();
                printVentas();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

        private void button5_Click(object sender, EventArgs e) // delete venta
        {
            try
            {
                if (dataGridView2.SelectedRows.Count == 1)
                {
                    Venta toDelete = (Venta)dataGridView2.SelectedRows[0].DataBoundItem;
                    controlVentas.delete(toDelete.ID);
                    clearInputsVentas();
                    printVentas();
                }
                else MessageBox.Show("Elige la fila de la venta a eliminar!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e) // update venta
        {
            try
            {
                if (dataGridView2.SelectedRows.Count == 1)
                {
                    if (textBox2.Text != "" && numericUpDown1.Value != 0)
                    {
                        Venta toUpdate = (Venta)dataGridView2.SelectedRows[0].DataBoundItem;
                        Venta updatedVenta = new Venta($"{textBox3.Text},{numericUpDown1.Value}");
                        controlVentas.update(toUpdate.ID, updatedVenta.getString());
                        clearInputsVentas();
                        printVentas();
                    }
                    else
                    {
                        MessageBox.Show("Completa los campos para proceder!!!");
                        textBox1.Focus();
                    }
                }
                else MessageBox.Show("Elige la fila de la venta a modificar!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked) controlVentas.orderListById();
            else if (radioButton3.Checked) controlVentas.orderListByMonto();
            else MessageBox.Show("Debe seleccionar una opción para ordenar!!!");
            printVentas();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView3.Rows.Clear();
                controlVendedores.orderListById();
                controlVentas.orderListById();
                List<Vendedor> vendedores = controlVendedores.createList();
                List<Venta> ventas = controlVentas.createList();
                
                decimal subtotalVendedor = 0;
                decimal totalFinal = 0;

                for(int i = 0; i < vendedores.Count; i++)
                {
                    string idVendedor = vendedores[i].ID;
                    dataGridView3.Rows.Add();
                    dataGridView3.Rows[i].Cells[0].Value = idVendedor;
                    for(int j = 0; j < ventas.Count; j++)
                    {
                        if (vendedores[i].ID == ventas[j].ID)
                        {
                            subtotalVendedor += ventas[j].Monto;
                            totalFinal += ventas[j].Monto;
                        }
                    }
                    dataGridView3.Rows[i].Cells[1].Value = subtotalVendedor;
                    subtotalVendedor = 0;
                }

                dataGridView3.Rows[vendedores.Count].Cells[0].Value = "Total Final";
                dataGridView3.Rows[vendedores.Count].Cells[1].Value = totalFinal;
                totalFinal = 0;
                subtotalVendedor = 0;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
