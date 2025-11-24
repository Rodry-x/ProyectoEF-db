using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormalizaT.EstructuraDeDatos
{
    internal class ListaEnlazada<T>
    {
        public Nodo<T>? Inicio { get; private set; }  // Cabeza verdadera
        public Nodo<T>? Fin { get; private set; }     // Cola opcional
        private int contador;

        public ListaEnlazada()
        {
            Inicio = null;
            Fin = null;
            contador = 0;
        }

        public void Agregar(T valor)
        {
            Nodo<T> nuevo = new Nodo<T>(valor);

            if (Inicio == null)
            {
                Inicio = nuevo;
                Fin = nuevo;
            }
            else
            {
                Fin!.Siguiente = nuevo;
                Fin = nuevo;
            }

            contador++;
        }

        public bool EstaVacia()
        {
            return Inicio == null;
        }

        public int Contar()
        {
            return contador;
        }

        public T? Obtener(int indice)
        {
            if (indice < 0 || indice >= contador)
                throw new IndexOutOfRangeException("Índice fuera de rango en ListaEnlazada.");

            Nodo<T>? actual = Inicio;
            int i = 0;

            while (actual != null)
            {
                if (i == indice)
                    return actual.Valor;

                actual = actual.Siguiente;
                i++;
            }

            return default;
        }

        public void Limpiar()
        {
            Inicio = null;
            Fin = null;
            contador = 0;
        }

        public IEnumerable<T> ObtenerElementos()
        {
            Nodo<T>? actual = Inicio;

            while (actual != null)
            {
                yield return actual.Valor;
                actual = actual.Siguiente;
            }
        }
    }
}
