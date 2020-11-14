using System;

namespace ArbolesBinarios
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda(5);
            arbol.InsertarNodo(15);
            arbol.InsertarNodo(20);
            arbol.InsertarNodo(18);
            arbol.InsertarNodo(80);
            arbol.InsertarNodo(64);
            arbol.InsertarNodo(100);
            arbol.InsertarNodo(19);
            arbol.InsertarNodo(35);
            arbol.InsertarNodo(50);
            arbol.InsertarNodo(90);
            arbol.InsertarNodo(43);
            arbol.InsertarNodo(22);
            arbol.InsertarNodo(1);
            arbol.InsertarNodo(3);
            arbol.InsertarNodo(8);



            Console.Write(arbol.ObtenerArbol());

            Console.WriteLine("");
            Console.WriteLine("--------Recorridos-------");
            Console.WriteLine(arbol.Recorrido());
            Console.WriteLine(arbol.Recorrido(tipoRecorrido: ArbolBinarioBusqueda.TipoRecorrido.Inorden));
            Console.WriteLine(arbol.Recorrido(null, ArbolBinarioBusqueda.TipoRecorrido.Posorden));
        }
    }
}
