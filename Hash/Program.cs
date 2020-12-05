using System;
using System.Collections;
using System.Collections.Generic;

namespace Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            MiHash datos = new MiHash();
            
            Personas Antonio = new Personas() { Nombre = "Antonio", Telefono = "6622102030" };
            Personas Jose = new Personas() { Nombre = "Jose", Telefono = "6622102030" };

            datos.Add("Uno", Antonio);
            datos.Add("Dos", Jose);

            Console.WriteLine($"Hash:{datos.Get("Dos")}");
            Personas resultado = (Personas)datos["Dos"];
            Console.WriteLine($"Nombre:{resultado.Nombre} teléfono:{resultado.Telefono}");

            ICollection llaves = datos.Keys;
            foreach(string llave in llaves) 
            {
                Personas resultado2 = (Personas)datos[llave];
                Console.WriteLine($"Para la llave {llave} Nombre:{resultado2.Nombre} teléfono:{resultado2.Telefono}");
            }

            if (datos.ContainsKey("Uno1"))
            {
                Console.WriteLine("Ya existe");
            }
            else 
            {
                Console.WriteLine("No existe");
            }

            datos.Remove("Uno");
            datos.Remove("Uno456");
        }

        public class Personas 
        {
            public string Nombre { get; set; }
            public string Telefono { get; set; }
        }
        public class MiHash : Hashtable 
        {
            public int Get(object key) 
            {
                return GetHash(key);
            }
        }
    }
}
