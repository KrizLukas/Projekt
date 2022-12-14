using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovyProjekt
{   /// <summary>
    /// Třída reprezentuje seznam pojištěných
    /// </summary>
    internal class SeznamPojistenych
    {
        /// <summary>
        /// Databáze se seznamem pojištěných
        /// </summary>
        private Databaze databaze;

        /// <summary>
        /// Vytvoří novou instanci seznamu pojištěných
        /// </summary>
        public SeznamPojistenych()
        {
            databaze = new Databaze();
        }

        /// <summary>
        /// Vypíše úvodní obrazovku
        /// </summary>
        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------\nEvidence pojištěných:\n-----------------------------");
            Console.WriteLine();
            Console.WriteLine("Vyberte si akci:");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat Pojištěného");
            Console.WriteLine("4 - Konec");
        }
        /// <summary>
        /// Vyzve uživatele k přidání nového pojištěného a uloží ho do databáze
        /// </summary>
        public void PridejNovehoPojisteneho()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Zadej text znovu:");
            }


            Console.WriteLine("Zadejte přijmení pojištěného:");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Zadej text znovu:");
            }

            Console.WriteLine("Zadejte telefonní číslo:");
            string telefonniCislo;
            while (string.IsNullOrWhiteSpace(telefonniCislo = Console.ReadLine()))
            {
                Console.WriteLine("Zadej text znovu:");
            }

            Console.WriteLine("Zadejte věk:");
            int vek;
            while (!int.TryParse(Console.ReadLine(), out vek))
            {
                Console.Write("Neplatný věk, zadejte prosím znovu: ");
            }

            databaze.PridejZaznam(jmeno, prijmeni, vek, telefonniCislo);

            Console.WriteLine("\nData byla uložena. Pokračujte libovolnou klávesou...");
        }

        /// <summary>
        /// Vypíše všechny pojištěné
        /// </summary>
        public void VypisVsechnyPojistene()
        {
            Console.WriteLine();
            databaze.ZobrazZaznamy();
        }


        /// <summary>
        /// Vyhledá pojištěné podle jména a přijmení
        /// </summary>
        public void VyhledatPojisteneho()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Zadej text znovu:");
            }

            Console.WriteLine("Zadejte přijmení pojištěného:");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Zadej text znovu:");
            }

            Clovek nalezeny = databaze.NajdiPojisteneho(jmeno, prijmeni);

            if (nalezeny != null)
            {
                Console.WriteLine("\nPojištěný nalezen: \n");
                Console.WriteLine(nalezeny);
                Console.WriteLine("\nPokračujte libovolnou klávesou...");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Pojištěný nenalezen. Pokračujte libovolnou klávesou...");
            }
        }
    }
}
