using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {string print = "hola";
        Console.WriteLine(print);

       
        
        Entradas en2 = new Entradas("d", 1);
        Entradas en3 = new Entradas("e", 0);
        Compuertas c2 = new Compuertas(en2);
        Console.WriteLine(c2.and(en2, en3));
        Console.WriteLine(c2.or(en2, en3));

        
    } 
    }
}


