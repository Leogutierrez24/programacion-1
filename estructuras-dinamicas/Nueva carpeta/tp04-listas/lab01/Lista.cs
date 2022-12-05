using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01
{
    public class Lista
    {
        Paciente Centinela;

        public Lista()
        {
            Centinela = new Paciente();
        }

        public void addPaciente(Paciente newPaciente)
        {
            if(Centinela.Siguiente == null) Centinela.Siguiente = newPaciente;        
            else
            {
                Paciente lastPaciente = getLast(Centinela.Siguiente);
                lastPaciente.Siguiente = newPaciente;
            }
        }

        public void deletePaciente(string pacienteCod)
        {
            // borrar paciente x id
            Paciente toDelete = searchId(Centinela.Siguiente, pacienteCod);

            if (toDelete == null) MessageBox.Show("No hay elementos para eliminar!!!");
            else
            {
                if(toDelete.Cod == Centinela.Siguiente.Cod)
                {
                    Paciente newFirst = toDelete.Siguiente;
                    Centinela.Siguiente = newFirst;
                    toDelete.Siguiente = null;

                    MessageBox.Show($"Se eliminó el Paciente con ID: {toDelete.Cod}");
                } else if(toDelete.Siguiente == null)
                {
                    int listaLength = getListaLength(Centinela.Siguiente);
                    Paciente pacienteAfterLast = getByPosition(Centinela.Siguiente, listaLength - 1, 1);
                    pacienteAfterLast.Siguiente = null;

                    MessageBox.Show($"Se eliminó el Paciente con ID: {toDelete.Cod}");
                } else
                {
                    int toDeletePosition = getPacientePosition(Centinela.Siguiente, pacienteCod);
                    Paciente pacienteAfterDelete = getByPosition(Centinela.Siguiente, toDeletePosition - 1, 1);
                    Paciente pacienteBeforeDelete = getByPosition(Centinela.Siguiente, toDeletePosition + 1, 1);

                    pacienteAfterDelete.Siguiente = pacienteBeforeDelete;
                    toDelete.Siguiente = null;

                    MessageBox.Show($"Se eliminó el Paciente con ID: {toDelete.Cod}");
                }
            }
        }

        public void updatePaciente(string pacienteCod)
        {
            // modificar paciente con x id
            Paciente pacienteToModify = searchId(Centinela.Siguiente, pacienteCod);
            if (pacienteToModify == null) MessageBox.Show("No se encontraron pacientes con ese código");
            else
            {
                pacienteToModify.Name = Interaction.InputBox($"Ingrese el nombre:");
                pacienteToModify.Surname = Interaction.InputBox($"Ingrese el apellido:");
                pacienteToModify.Dir = Interaction.InputBox($"Ingrese la dirección:");
                pacienteToModify.Phone = Interaction.InputBox($"Ingrese el número de telefono:");

                MessageBox.Show("Paciente modificado!!!");
            }
        }

        public void addIn(Paciente newPaciente, int position)
        {
            // agregar paciente en x posición
            int listaLength = getListaLength(Centinela.Siguiente);
            if (position > listaLength + 1 || position < 0) MessageBox.Show("La posición seleccionada es inválida!!!");
            else
            {
                if (position == 1)
                {
                    if (listaLength == 0) Centinela.Siguiente = newPaciente;
                    else if(listaLength > 0)
                    {
                        Paciente beforePaciente = Centinela.Siguiente;
                        Centinela.Siguiente = newPaciente;
                        newPaciente.Siguiente = beforePaciente;
                    }
                } else if(position == listaLength + 1)
                {
                    Paciente lastPaciente = getLast(Centinela.Siguiente);
                    lastPaciente.Siguiente = newPaciente;
                } else
                {
                    Paciente beforePaciente = getByPosition(Centinela.Siguiente, position, 1);
                    Paciente afterPaciente = getByPosition(Centinela.Siguiente, position - 1, 1);

                    afterPaciente.Siguiente = newPaciente;
                    newPaciente.Siguiente = beforePaciente;
                }
            }
        }

        public Paciente getFirst()
        {
            if (Centinela.Siguiente == null) return null;
            else return Centinela.Siguiente;
        }

        private Paciente getLast(Paciente unPaciente)
        {
            Paciente lastPaciente = unPaciente;
            if (unPaciente.Siguiente != null) lastPaciente = getLast(unPaciente.Siguiente);
            return lastPaciente;
        }

        private Paciente getByPosition(Paciente unPaciente, int position, int pacientePosition)
        {
            Paciente thePaciente = unPaciente;
            if (pacientePosition != position) thePaciente = getByPosition(thePaciente.Siguiente, position, pacientePosition + 1);
            return thePaciente;
        }

        private int getPacientePosition(Paciente unPaciente, string id)
        {
            int position = 1;
            if (unPaciente.Cod != id) position = 1 + getPacientePosition(unPaciente.Siguiente, id);
            return position;
        }

        private int getListaLength(Paciente unPaciente)
        {
            int length = 1;
            if(unPaciente != null)
            {
                if (unPaciente.Siguiente != null) length = 1 + getListaLength(unPaciente.Siguiente);
            } else
            {
                length = 0;
            }
            return length;
        }

        private Paciente searchId(Paciente unPaciente, string id)
        {
            Paciente randomPaciente = unPaciente;
            if(randomPaciente != null)
            {
                if (randomPaciente.Cod != id) randomPaciente = searchId(randomPaciente.Siguiente, id);
            }
            return randomPaciente;
        }
    }
}
