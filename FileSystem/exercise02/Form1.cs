using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace exercise02
{
    public partial class Form1 : Form
    {
        string url = "datos.txt";

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int totalPorCadena = 0;
                int totalPorProvincia = 0;
                int cantCadenas = 0;
                int cantImpuestos = 0;
                bool agregar = false;
                int i = 0;

                if (File.Exists(url))
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add();
                    FileStream fs = new FileStream(url, FileMode.Open, FileAccess.Read);
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = sr.ReadLine();
                        string[] data = line.Split(new char[] {','});

                        while (line != null)
                        {
                            string provincia = data[0];
                            dataGridView1.Rows.Add(new string[] { data[0] } );
                            i++;

                            while (provincia == data[0] && line != null) // Mientras la provincia sea la misma
                            {
                                string cadena = data[1];
                                cantCadenas++;

                                if (agregar)
                                {
                                    dataGridView1.Rows.Add(new string[] { "", cadena });
                                    i++;
                                } else 
                                {
                                    dataGridView1.Rows[i].Cells[1].Value = data[1];
                                    agregar = true;
                                }

                                while (provincia == data[0] && cadena == data[1] && line != null) // Mientras la cadena sea la misma
                                {
                                    string impuesto = data[2];
                                    cantImpuestos++;

                                    while (provincia == data[0] && cadena == data[1] && impuesto == data[2] && line != null) // Mientras el impuesto sea el mismo
                                    {
                                        totalPorCadena += int.Parse(data[3]);
                                        totalPorProvincia += int.Parse(data[3]);

                                        line = sr.ReadLine();
                                        if (line != null)
                                        {
                                            data = line.Split(new char[] { ',' });
                                        }                                   
                                    }
                                }

                                dataGridView1.Rows[i].Cells[2].Value = cantImpuestos;
                                dataGridView1.Rows[i].Cells[3].Value = totalPorCadena;
                                totalPorCadena = 0;
                                cantImpuestos = 0;

                            }
                            dataGridView1.Rows.Add(new string[] { "Cantidad de Cadenas:", $"{cantCadenas}", "Importe por Provincia:", $"{totalPorProvincia}" });
                            i++;
                            totalPorProvincia = 0;
                            totalPorCadena = 0;
                            cantImpuestos = 0;
                            cantCadenas = 0;
                            agregar = false;
                        }
                    }
                    fs.Close();
                } else
                {
                    File.Create(url);
                    MessageBox.Show("Archivo creado.");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
