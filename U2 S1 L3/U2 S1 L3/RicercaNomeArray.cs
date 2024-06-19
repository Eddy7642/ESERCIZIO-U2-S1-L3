using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_S1_L3
{
    class U2_S1_L31
    {
        static void Main(string[] args)
        {
            string[] nomi = new string[5]; // Dimensione dell'array decisa dal candidato
            Console.WriteLine("Inserisci 5 nomi:");

            for (int i = 0; i < nomi.Length; i++)
            {
                Console.Write($"Nome {i + 1}: ");
                nomi[i] = Console.ReadLine();
            }

            Console.Write("Inserisci il nome da ricercare: ");
            string nomeDaRicercare = Console.ReadLine();

            bool trovato = false;
            foreach (string nome in nomi)
            {
                if (nome.Equals(nomeDaRicercare, StringComparison.OrdinalIgnoreCase))
                {
                    trovato = true;
                    break;
                }
            }

            if (trovato)
            {
                Console.WriteLine("Nome trovato nell'array.");
            }
            else
            {
                Console.WriteLine("Nome non presente nell'array.");
            }
        }
    }
}

    

