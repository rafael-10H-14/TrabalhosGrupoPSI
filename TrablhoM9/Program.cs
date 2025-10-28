using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrablhoM9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Digite um número inteiro {i+1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
        }
    }
}
