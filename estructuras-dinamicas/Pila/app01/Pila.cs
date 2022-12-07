using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app01
{
    public class Pila
    {
        Contenedor Puntero;

        public Pila()
        {
            Puntero = new Contenedor();
        }

        public void push(Contenedor newContenedor)
        {
            if (Puntero.Siguiente == null) Puntero.Siguiente = newContenedor;
            else
            {
                Contenedor lastContenedor = Puntero.Siguiente;
                newContenedor.Siguiente = lastContenedor;
                Puntero.Siguiente = newContenedor;
            }
        }

        public Contenedor pop()
        {
            Contenedor contenedorAux = Puntero.Siguiente;
            if (contenedorAux != null)
            {
                Puntero.Siguiente = contenedorAux.Siguiente;
                contenedorAux.Siguiente = null;
            }

            return contenedorAux;
        }

        public Contenedor getLastOne()
        {
            Contenedor auxContenedor = Puntero.Siguiente;
            return auxContenedor;
        }

        private Contenedor findContenedorById(Contenedor unContenedor, string id)
        {
            Contenedor auxContenedor = Puntero.Siguiente;
            if(auxContenedor != null)
            {
                if (auxContenedor.Id != id) auxContenedor = findContenedorById(auxContenedor.Siguiente, id);
            }
            return auxContenedor;
        }


    }
}
