using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace app01
{
    public class Cola
    {
        Paciente Puntero;

        public Cola() 
        {
            Puntero = new Paciente();
        }

        public void enqueue(Paciente newPaciente)
        {
            if(Puntero.Siguiente == null) Puntero.Siguiente = newPaciente;
            else
            {
                Paciente lastPacient = getLastOne(Puntero.Siguiente);
                lastPacient.Siguiente = newPaciente;
            }
        }

        public Paciente dequeue()
        {
            Paciente dequeuedPaciente = Puntero.Siguiente;
            if(dequeuedPaciente != null)
            {
                Puntero.Siguiente = dequeuedPaciente.Siguiente;
                dequeuedPaciente.Siguiente = null;
            }
            return dequeuedPaciente;
        }

        private Paciente getLastOne(Paciente unPaciente)
        {
            Paciente auxPaciente = unPaciente;
            if(auxPaciente != null)
            {
                if (auxPaciente.Siguiente != null) auxPaciente = getLastOne(auxPaciente.Siguiente);
            }
            return auxPaciente;
        }

        public Paciente getFirstOne()
        {
            Paciente auxPaciente = Puntero.Siguiente;
            return auxPaciente;
        }
    }
}
