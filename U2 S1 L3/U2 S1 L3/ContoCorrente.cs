using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_S1_L3
{
    class ContoCorrente
    {

        // Proprietà del conto
        public string NumeroConto { get; private set; }
        public string Intestatario { get; private set; }
        public decimal Saldo { get; private set; }
        public bool ContoAperto { get; private set; }

        // Costruttore
        public ContoCorrente(string numeroConto, string intestatario)
        {
            NumeroConto = numeroConto;
            Intestatario = intestatario;
            Saldo = 0;
            ContoAperto = false;
        }

        // Metodo per aprire il conto
        public void ApriConto(decimal versamentoIniziale)
        {
            if (ContoAperto)
            {
                Console.WriteLine("Il conto è già aperto.");
                return;
            }

            if (versamentoIniziale < 1000)
            {
                Console.WriteLine("Per aprire il conto è necessario un versamento iniziale di almeno 1000 euro.");
                return;
            }

            Saldo = versamentoIniziale;
            ContoAperto = true;
            Console.WriteLine($"Conto aperto con successo. Saldo iniziale: {Saldo} euro.");
        }

        // Metodo per fare un versamento
        public void FaiVersamento(decimal importo)
        {
            if (!ContoAperto)
            {
                Console.WriteLine("Il conto non è aperto.");
                return;
            }

            Saldo += importo;
            Console.WriteLine($"Versamento di {importo} euro effettuato con successo. Saldo attuale: {Saldo} euro.");
        }

        // Metodo per fare un prelevamento
        public void FaiPrelevamento(decimal importo)
        {
            if (!ContoAperto)
            {
                Console.WriteLine("Il conto non è aperto.");
                return;
            }

            if (importo > Saldo)
            {
                Console.WriteLine("Saldo insufficiente per il prelevamento richiesto.");
                return;
            }

            Saldo -= importo;
            Console.WriteLine($"Prelevamento di {importo} euro effettuato con successo. Saldo attuale: {Saldo} euro.");
        }
    }

    class U2_S1_L3
    {
        static void Main(string[] args)
        {
            ContoCorrente mioConto = new ContoCorrente("123456789", "Mario Rossi");

            mioConto.ApriConto(1200); // Prova ad aprire il conto con 1200 euro
            mioConto.FaiVersamento(300); // Versamento di 300 euro
            mioConto.FaiPrelevamento(500); // Prelevamento di 500 euro
        }
    }
}
 
   