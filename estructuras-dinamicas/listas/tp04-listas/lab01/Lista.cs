using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Paciente lastPaciente = findLast(Centinela.Siguiente);
                lastPaciente.Siguiente = newPaciente;
            }
        }

        public void deletePaciente()
        {
            // borrar paciente x id
        }

        public void updatePaciente()
        {
            // modificar paciente con x id
        }

        public void addIn()
        {
            // agregar paciente en x posición
        }

        private Paciente findLast(Paciente unPaciente)
        {
            Paciente lastPaciente = unPaciente;
            if (unPaciente.Siguiente != null) lastPaciente = findLast(unPaciente.Siguiente);
            return lastPaciente;
        }

        public Paciente getFirst()
        {
            if (Centinela.Siguiente == null) return null;
            else return Centinela.Siguiente;
        }
    }
}
