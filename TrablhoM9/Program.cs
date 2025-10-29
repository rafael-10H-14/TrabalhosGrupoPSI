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
            int maximo = numeros[0];
            int indice = 0;
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                    indice = i;
                }
            }
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("Maior número: {0}, índice: {1}", maximo, indice);
            Console.WriteLine("Bom dia");
            Console.ReadKey();
        }
    }
}
