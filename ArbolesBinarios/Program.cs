using System;

namespace ArbolesBinarios
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda(35);
            arbol.InsertarNodo(20);
            arbol.InsertarNodo(15);
            arbol.InsertarNodo(40);
            arbol.InsertarNodo(25);

            Console.Write(arbol.ObtenerArbol());
        }
    }
}
