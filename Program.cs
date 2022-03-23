﻿using System;

namespace CalculatorCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse( Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse( Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é: " + resultado );

            /* outras formas de soma:
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.WriteLine($"O resultado da soma é {v1 + v2}");
            Console.WriteLine("O resultado da soma é " + (v1 + v2));
            */
        }
    }
}
