using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manejo_archivos2
{
    public partial class Form1 : Form
    {
        ControlAlumno controlAlumnos;
        ControlNota controlNotas;
        public Form1()
        {
            InitializeComponent();
            controlAlumnos = new ControlAlumno();
            controlNotas = new ControlNota();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            printAlumnos();
            printNotas();
        }

        public void printAlumnos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controlAlumnos.getListAlumnos();
        }

        public void printNotas()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = controlNotas.getListNotas();
        }

        public void clearInputsAlumno()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            numericUpDown1.Value = 10000000;
        }

        public void clearInputsNota()
        {
            numericUpDown2.Value = 10000000;
            numericUpDown3.Value = 1;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string dataAlumno = $"{numericUpDown1.Value},{textBox1.Text},{textBox2.Text}";
                Alumno newAlumno = new Alumno(dataAlumno);
                controlAlumnos.save(newAlumno.createString());
                clearInputsAlumno();
                printAlumnos();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    Alumno toDelete = (Alumno)dataGridView1.SelectedRows[0].DataBoundItem;
                    controlAlumnos.delete(toDelete.DNI);
                    clearInputsAlumno();
                    printAlumnos();
                }
                else MessageBox.Show("Seleccione la fila del alumno a borrar");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    Alumno updatedAlumno = new Alumno($"{Interaction.InputBox("Nuevo dni:")},{Interaction.InputBox("Nuevo nombre:")},{Interaction.InputBox("Nuevo apellido:")}");
                    Alumno toUpdate = (Alumno)dataGridView1.SelectedRows[0].DataBoundItem;
                    controlAlumnos.update(toUpdate.DNI, updatedAlumno);
                    clearInputsAlumno();
                    printAlumnos();
                }
                else MessageBox.Show("Seleccione la fila del alumno a modificar");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string notaData = $"{numericUpDown2.Value},{Convert.ToInt16(numericUpDown3.Value)},{dateTimePicker1.Value.ToShortDateString()}";
                Nota newNota = new Nota(notaData);
                controlNotas.save(newNota.createString());
                clearInputsNota();
                printNotas();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedRows.Count == 1)
                {
                    Nota toDelete = (Nota)dataGridView2.SelectedRows[0].DataBoundItem;
                    controlNotas.delete(toDelete.DNI, toDelete.Calif, toDelete.Fecha);
                    clearInputsNota();
                    printNotas();
                }
                else MessageBox.Show("Seleccione la fila de la nota a borrar");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedRows.Count == 1)
                {
                    Nota updatedNota = new Nota($"{Interaction.InputBox("Nuevo dni:")},{Interaction.InputBox("Nueva nota:")},{Interaction.InputBox("Nuevo fecha(dd/mm/yy):")}");
                    Nota toUpdate = (Nota)dataGridView2.SelectedRows[0].DataBoundItem;
                    controlNotas.update(toUpdate.DNI, toUpdate.Calif, toUpdate.Fecha, updatedNota);
                    clearInputsNota();
                    printNotas();
                }
                else MessageBox.Show("Seleccione la fila del alumno a modificar");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                controlAlumnos.orderById();
                printAlumnos();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                controlNotas.orderById();
                printNotas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<Alumno> alumnos = controlAlumnos.orderById();
            List<Nota> notas = controlNotas.orderById();
            List<Promedio> promedios = new List<Promedio>();

            int totalNotas = 0;
            int qtyNotas = 0;
            decimal promedio = 0;

            for(int i = 0; i < alumnos.Count; i++)
            {
                Promedio prom = new Promedio();
                prom.DNI = alumnos[i].DNI;
                prom.Nombre = alumnos[i].Nombre;
                prom.Apellido = alumnos[i].Apellido;

                for(int j = 0; j < notas.Count; j++)
                {
                    if (alumnos[i].DNI == notas[j].DNI)
                    {
                        totalNotas += notas[j].Calif;
                        qtyNotas++;
                    }
                }

                promedio = qtyNotas == 0 ? 0 : totalNotas / qtyNotas;
                prom.NotaFinal = promedio;
                promedios.Add(prom);
                totalNotas = 0;
                qtyNotas = 0;
                promedio = 0;
            }

            dataGridView3.DataSource = null;
            dataGridView3.DataSource = promedios;
        }
    }
}
