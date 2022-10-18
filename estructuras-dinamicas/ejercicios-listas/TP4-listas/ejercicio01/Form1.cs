using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ejercicio01
{
    public partial class Form1 : Form
    {
        PacientList pacientList01;
        public Form1()
        {
            InitializeComponent();
            pacientList01 = new PacientList();
        }

        private void button1_Click(object sender, EventArgs e) // button add new pacient
        {
            try
            {
                Pacient newPacient = new Pacient
                {
                    Name = textBox1.Text,
                    Surname = textBox2.Text,
                    PhoneNumber = textBox3.Text,
                    Adress = textBox4.Text,
                    Id = textBox5.Text
                };
                pacientList01.addNewPacient(newPacient);
                listView1.Items.Add($"{newPacient.Name} {newPacient.Surname}");
                cleanInputs();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cleanInputs()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e) // button delete a pacient with n position
        {
            try
            {
                int positionToDelete = Int32.Parse(Interaction.InputBox("Ingrese la posición del paciente que desea eliminar: "));
                if (pacientList01.deletePacient(positionToDelete) == null) MessageBox.Show("El número ingresado es inválido!!!");
                else MessageBox.Show($"Se elimino al paciente {pacientList01.deletePacient(positionToDelete).Surname} con la posición {positionToDelete}");                
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e) // button change pacient data
        {
            try
            {
                string pacientId = Interaction.InputBox("Ingrese el ID del paciente a actualizar: ");
                Pacient toUpdatePacient = pacientList01.updatePacient(pacientId);
                if (toUpdatePacient == null) MessageBox.Show($"No se encontro paciente con ID: {pacientId}!!!");
                else
                {
                    int propToChange = Int32.Parse(Interaction.InputBox($"¿Qué propiedad desea modificar?{Environment.NewLine}1) Nombre{Environment.NewLine}2) Apellido{Environment.NewLine}3) N° Telefono{Environment.NewLine}4) Dirección{Environment.NewLine}5) ID{Environment.NewLine}"));
                    pacientList01.changePropierties(toUpdatePacient, propToChange);
                }
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
                int newPacientPosition = Int32.Parse(Interaction.InputBox("Ingrese la posición en la que desea insertar: "));
                Pacient newPacient = new Pacient
                {
                    Name = textBox1.Text,
                    Surname = textBox2.Text,
                    PhoneNumber = textBox3.Text,
                    Adress = textBox4.Text,
                    Id = textBox5.Text
                };
                pacientList01.insertNewPacient(newPacient, newPacientPosition);
                MessageBox.Show("Paciente Agregado en la Posición: " + newPacientPosition);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e) // button see a pacient by ID
        {
            try
            {
                string pacientId = Interaction.InputBox("Ingrese el ID del paciente deseado: ");
                Pacient toShowPacient = pacientList01.showPacient(pacientId);
                MessageBox.Show($"{(toShowPacient == null ? "No hay paciente con ID: " + pacientId : "nombre: " + toShowPacient.Name + Environment.NewLine + "apellido: " + toShowPacient.Surname)}");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

    public class PacientList
    {
        Pacient sentinel;
        public PacientList()
        {
            sentinel = new Pacient();
        }
        
        public void addNewPacient(Pacient newPacient)
        {
            if (sentinel.Next == null) sentinel.Next = newPacient;
            else
            {
                findLastPacient(sentinel.Next).Next = newPacient;
            }
        }

        public Pacient deletePacient(int position)
        {
            int listLength = listQuantity(sentinel, 0);
            if (position <= 0 || position > listLength) throw new Exception("La posición ingresada es inválida ! ! !");
            Pacient auxPacient = findPacientPosition(sentinel.Next, position);
            if (position == 1)
            {
                sentinel.Next = auxPacient.Next;
                auxPacient.Next = null;
            }
            else if (position == listLength)
            {
                Pacient previousPacient = findPacientPosition(sentinel.Next, position - 1);
                previousPacient.Next = null;
                auxPacient.Next = null;
            }
            else
            {
                Pacient nextPacient = findPacientPosition(sentinel.Next, position + 1);
                Pacient previousPacient = findPacientPosition(sentinel.Next, position - 1);
                auxPacient.Next = null;
                previousPacient.Next = nextPacient;
            }
            return auxPacient;
        }

        public  Pacient updatePacient(string id)
        {
            Pacient auxPacient = findPacientId(sentinel, id);
            return auxPacient;
        }

        public void insertNewPacient(Pacient newPacient, int position)
        {
            int listLength = listQuantity(sentinel, 0);
            if (position <= 0 || position >= listLength + 2) throw new Exception("La posición ingresada es inválida ! ! !");
            if (position == 1)
            {
                Pacient nextPacient = findPacientPosition(sentinel.Next, position);
                sentinel.Next = newPacient;
                newPacient.Next = nextPacient;
            } else if(position < listLength)
            {
                Pacient nextPacient = findPacientPosition(sentinel.Next, position);
                Pacient previousPacient = findPacientPosition(sentinel.Next, position - 1);
                previousPacient.Next = newPacient;
                newPacient.Next = nextPacient;
            } else if(position > listLength)
            {
                Pacient previousPacient = findPacientPosition(sentinel.Next, position - 1);
                previousPacient.Next = newPacient;
            }
        }

        private Pacient findLastPacient(Pacient randomPacient)
        {
            Pacient thePacient = randomPacient;
            if (thePacient.Next != null) thePacient = findLastPacient(randomPacient.Next);
            return thePacient;
        }
      
        private int listQuantity(Pacient randomPacient, int x)
        {
            int quantity = x;
            if (randomPacient.Next != null) quantity = listQuantity(randomPacient.Next, quantity + 1);
            return quantity;
        }

        private Pacient findPacientPosition(Pacient randomPacient, int position)
        {
            Pacient auxPacient = randomPacient;
            if (position != 1) auxPacient = findPacientPosition(auxPacient.Next, position - 1);
            return auxPacient;
        }

        public Pacient showPacient(string position)
        {
            return findPacientId(sentinel, position);
        }

        private Pacient findPacientId(Pacient randomPacient, string pacientId)
        {
            Pacient auxPacient = null;
            if (randomPacient.Next != null)
            {
                if (randomPacient.Next.Id != pacientId) auxPacient = findPacientId(randomPacient.Next, pacientId);
                else auxPacient = randomPacient.Next;
            }
            return auxPacient;
        }

        public void changePropierties(Pacient randomPacient, int option)
        {
            if(option == 1)
            {
                randomPacient.Name = Interaction.InputBox("Ingrese el nuevo nombre: ");
            } else if (option == 2)
            {
                randomPacient.Surname = Interaction.InputBox("Ingrese el nuevo apellido: ");
            } else if(option == 3)
            {
                randomPacient.PhoneNumber = Interaction.InputBox("Ingrese el nuevo número: ");
            } else if(option == 4)
            {
                randomPacient.Adress = Interaction.InputBox("Ingrese la nueva dirección: ");
            } else if(option == 5)
            {
                randomPacient.Id = Interaction.InputBox("Ingrese el nuevo ID: ");
            } else
            {
                MessageBox.Show("El número de opción ingresado no es válido!!!");
            }
        }

    }

    public class Pacient
    {
        public Pacient(string id = "", string name = "", string surname = "", string adress = "", string phoneNumber = "")
        {
            Id = id;
            Name = name;
            Surname = surname;
            Adress = adress;
            PhoneNumber = phoneNumber;
            Next = null;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public Pacient Next { get; set; }

    }
}
