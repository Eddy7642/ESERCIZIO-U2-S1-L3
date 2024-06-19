using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_S1_L3
{
    internal class SommaEMediaArray
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci la dimensione dell'array: ");
            int dimensione = int.Parse(Console.ReadLine());

            int[] numeri = new int[dimensione];
            Console.WriteLine($"Inserisci {dimensione} numeri interi:");

            for (int i = 0; i < dimensione; i++)
            {
                Console.Write($"Numero {i + 1}: ");
                numeri[i] = int.Parse(Console.ReadLine());
            }

            int somma = 0;
            for (int i = 0; i < numeri.Length; i++)
            {
                somma += numeri[i];
            }

            double media = (double)somma / numeri.Length;

            Console.WriteLine($"La somma dei numeri inseriti è: {somma}");
            Console.WriteLine($"La media aritmetica dei numeri inseriti è: {media}");
        }
    }
}

