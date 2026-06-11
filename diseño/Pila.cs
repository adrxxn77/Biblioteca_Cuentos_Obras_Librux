using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public class Pila
    {
        public NodoPila cima;

        public void Apilar(string accion)
        {
            NodoPila nuevo = new NodoPila();
            nuevo.accion = accion;
            nuevo.siguiente = cima;
            cima = nuevo;
        }

        public void Mostrar(ListBox lista)
        {
            lista.Items.Clear(); // Limpia antes de mostrar
            NodoPila aux = cima;
            while (aux != null)
            {
                lista.Items.Add(aux.accion);
                aux = aux.siguiente;
            }
        }
    }
}
