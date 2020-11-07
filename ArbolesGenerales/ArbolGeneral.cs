using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolesGenerales
{
    public class ArbolGeneral
    {
        private readonly Nodo raiz;
        public Nodo Raiz => raiz;

        public ArbolGeneral(string dato)
        {
            this.raiz = new Nodo(dato);
        }

        public Nodo InsertarNodo(string dato, Nodo nodoPadre)
        {
            if (nodoPadre == null) 
            {
                throw new Exception($"No se pudo insertar el valor " +
                    $"{dato}, se debe especificar el nodo padre");
            }

            if (nodoPadre.Hijo == null)
            {
                nodoPadre.Hijo = new Nodo(dato);
                return nodoPadre.Hijo;
            }
            else 
            {
                Nodo hijoNodoPadre = nodoPadre.Hijo;
                while(hijoNodoPadre.Hermano != null) 
                {
                    hijoNodoPadre = hijoNodoPadre.Hermano;
                }
                hijoNodoPadre.Hermano = new Nodo(dato);
                return hijoNodoPadre.Hermano;
            }
        }
    }
}
