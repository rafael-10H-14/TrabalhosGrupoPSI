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
            DizerSaudacao();
            Console.WriteLine();
            int[] numeros = new int[10];
            Console.WriteLine($"Digite números inteiros: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{i+1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            int maximo = numeros[0];
            int indice = 1;
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
            Console.ReadKey();
        }
        private static void DizerSaudacao()
        {
            int hora = DateTime.Now.Hour;
            string saudacao;
            if (hora >= 6 && hora < 12)
            {
                saudacao = "Bom dia";
            }
            else if (hora >= 12 && hora < 18)
            {
                saudacao = "Boa tarde";
            }
            else
            {
                saudacao = "Boa noite";
            }
            Console.WriteLine(saudacao);
        }
    }
}
