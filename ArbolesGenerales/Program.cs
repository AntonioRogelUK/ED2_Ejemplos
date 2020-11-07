using System;

namespace ArbolesGenerales
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolGeneral arbol = new ArbolGeneral("A");
            Nodo nodoB = arbol.InsertarNodo("B", arbol.Raiz);
            Nodo nodoD = arbol.InsertarNodo("D", nodoB);
            Nodo nodoE = arbol.InsertarNodo("E", nodoB);

            Console.WriteLine("");
        }
    }
}


