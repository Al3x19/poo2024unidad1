using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCsharp.Ejemplos
{
    public class Arreglo
    {
        private int ver { get; set; }
        public Arreglo(int ver)
        {
            this.ver = ver;
        }
        //public void PrintArray()
        public void PrintArrayLimit()
        {
            string[] nombres = { "Juan", "Maria", "Ruperto", "Petronila", "Ramon"
        };
            for (int i = 0; i < ver; i++)
            {
                Console.WriteLine("Hola" + nombres[i]);
            }
            //    int x = 0;

            //foreach (var nombre in nombres) 
            //    {
            //        if (x < ver)
            //        {
            //            Console.WriteLine("Hola" + nombre);
            //        }

            //    }

            //}

        }
    }
}

