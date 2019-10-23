using System;
using System.Collections.Generic;
using System.Linq;

namespace PPPPPPPPPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FASE1---------------");
            //  FASE 1
            char[] miNombre = { 'f', 'a', 'b', 'r', 'i', 'z', 'i', 'o' }; 
            Console.WriteLine("");
            foreach (char i in miNombre)
            {
                Console.WriteLine(i);
            }
           
            Console.WriteLine("FASE2--------------");
            //  FASE 2 
            var miNombre1 = new List<char>(miNombre);
            //Console.WriteLine("La lista tiene: " + miNombre1.Count + " items");

            var vocali = new[] { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine(vocali);
            Console.WriteLine("");
            foreach (var i in miNombre1)    // si/no vocale  ??mostrar numero
            {
                if (i == vocali[0])
                {
                    Console.WriteLine($"{i} es una vocal");
                }
                else if (i == vocali[1])
                {
                    Console.WriteLine($"{i} es una vocal");
                }
                else if (i == vocali[2])
                {
                    Console.WriteLine($"{i} es una vocal");
                }
                else if (i == vocali[3])
                {
                    Console.WriteLine($"{i} es una vocal");
                }
                else if (i == vocali[4])
                {
                    Console.WriteLine($"{i} es una vocal");
                }
                

                else
                {
                    Console.WriteLine($"{i} no es una vocal");
                }

            }

            Console.WriteLine("Vocali nombre ----------------");
            char[] cognomeVocali = { 'p', 'a', 'n', 't', 'i', 'n', 'i' };        
            foreach (var i in vocali)    //cuenta vocali
            {
                var contaVocali = miNombre1.Count(x => x == i);
                Console.WriteLine($"hay {contaVocali} vocali {i}");
            }
            
            Console.WriteLine("Vocali appellido ----------------");
            foreach (var i in vocali)    //cuenta vocali
            {
                var contaVocaliDue = cognomeVocali.Count(x => x == i);
                Console.WriteLine($"hay {contaVocaliDue} vocali {i}");
            }

            Console.WriteLine("FASE3---------------");
            //  FASE 3

            Dictionary<int, char> provaDizionario = new Dictionary<int, char>
            {
                {1, 'p' },
                {2, 'a' },
                {3, 'n' },
                {4, 't' },
                {5, 'i' },
                {6, 'n' },
                {7, 'i' },
            };
            
            Console.WriteLine($"Dictionary 'provaDizionario' contiene: {provaDizionario.Count} items");
            foreach ( var i  in provaDizionario.Values)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("FASE4---------------");
            //  FASE 4
            
            //  creo lista char por apellido
            var miListaCognome = new List<char>(cognomeVocali);
            //  fusiono los 2 array apellido+nombre
            miListaCognome.AddRange(miNombre1);
            Console.WriteLine($"mi lista contiene {miListaCognome.Count} items");

            //  añado el valor ' ' en posicion4
            miListaCognome.Insert(7, ' ');
            Console.WriteLine($"mi lista ahora contiene {miListaCognome.Count} items");

            foreach (var i in miListaCognome)
            {
                Console.WriteLine(i);
            }

          

        }

         
         
    }
}
