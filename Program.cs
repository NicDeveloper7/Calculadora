// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, resultado;

            Console.WriteLine("Digite o primeiro valor para realizar uma soma: ");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            v2 = int.Parse(Console.ReadLine());
            resultado = v1 + v2;
            Console.WriteLine($"O resultado da sua conta é:" + resultado);
            Console.ReadKey();
        }
    }
}

