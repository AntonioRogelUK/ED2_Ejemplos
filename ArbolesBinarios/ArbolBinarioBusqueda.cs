using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolesBinarios
{
    public class ArbolBinarioBusqueda
    {
        private readonly Nodo raiz;

        public Nodo Raiz => raiz;

        public ArbolBinarioBusqueda(int dato)
        {
            this.raiz = new Nodo(dato);
        }

        public enum TipoRecorrido 
        {
            Preorden,
            Inorden,
            Posorden
        }
      
        public void InsertarNodo(int dato, Nodo nodo = null) 
        {
            nodo ??= this.raiz;

            if (dato > nodo.Dato) 
            {
                nodo.HijoDerecho ??= new Nodo(dato);
                InsertarNodo(dato, nodo.HijoDerecho);
            }
            else if (dato < nodo.Dato) 
            {
                nodo.HijoIzquierdo ??= new Nodo(dato);
                InsertarNodo(dato, nodo.HijoIzquierdo);
            }
        }

        public string ObtenerArbol(Nodo nodo = null) 
        {
            nodo ??= this.raiz;
            string datos = string.Empty;
            RecorrerArbol(nodo, ref datos);
            return datos;
        }

        private void RecorrerArbol(Nodo nodo, ref string datos) 
        {
            if (nodo != null) 
            {
                string raiz = (datos == string.Empty) ? "Raiz" : string.Empty;
                datos += $"{raiz}{nodo.Dato,5}\n";

                if (nodo.HijoIzquierdo != null) 
                {
                    datos += $"{nodo.Dato, -5}< ";
                    RecorrerArbol(nodo.HijoIzquierdo, ref datos);
                }

                if (nodo.HijoDerecho != null)
                {
                    datos += $"{nodo.Dato, -5}> ";
                    RecorrerArbol(nodo.HijoDerecho, ref datos);
                }
            }
        }
    }
}