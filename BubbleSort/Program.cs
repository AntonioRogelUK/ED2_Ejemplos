using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>
            {
                3,2,8,1,9,0,10,7
            };
            int tope = lista.Count;

            Console.WriteLine($"Datos antes de ordenar: {ImprimeLista(lista)}");
            Console.WriteLine("");

            for (int inicio = 1; inicio < tope - 1; inicio++) 
            {
                for (int i = 0; i < tope - inicio; i++) 
                {
                    int valori = lista[i];
                    int valorSiguiente = lista[i + 1];
                    if(valori > valorSiguiente) 
                    {
                        lista[i] = valorSiguiente;
                        lista[i + 1] = valori;
                    }
                }
                Console.WriteLine($"Pasada {inicio}: {ImprimeLista(lista)}");
            }

            Console.WriteLine("");
            Console.WriteLine($"Datos después de ordenar: {ImprimeLista(lista)}");
        }
        public static string ImprimeLista(List<int> lista) 
        {
            string datos = string.Empty;
            foreach(int dato in lista) 
            {
                datos += (string.IsNullOrEmpty(datos)) 
                    ? dato.ToString() 
                    : $",{dato}";
            }
            return datos;
        } 
    }
}
