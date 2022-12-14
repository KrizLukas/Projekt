using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovyProjekt
{   /// <summary>
    /// Třída spravuje kolekci záznamů
    /// </summary>
    internal class Databaze
    {   /// <summary>
        /// Kolekce seznamů
        /// </summary>
        private List<Clovek> seznamy;
        /// <summary>
        /// Vytvoří novou instanci databáze
        /// </summary>
        public Databaze()
        {
            seznamy = new List<Clovek>();
        }
        /// <summary>
        /// Přidá nový záznam do databáze
        /// </summary>
        /// <param name="clovek"></param>
        public void PridejZaznam(string jmeno, string prijmeni, int vek, string telefonniCislo)
        {
            seznamy.Add(new Clovek(jmeno, prijmeni, vek, telefonniCislo));
        }
        /// <summary>
        /// Zobrazí všechny záznamy
        /// </summary>
        public void ZobrazZaznamy()
        {
            foreach (Clovek clovek in seznamy)
            {
                Console.WriteLine(clovek);
            }
            Console.WriteLine("\nPokračujte libovolnou klávesou...");
        }
        /// <summary>
        /// Najde pojišténého podle jména a přijmení
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <returns></returns>
        public Clovek NajdiPojisteneho(string jmeno, string prijmeni)
        {
            foreach (Clovek clovek in seznamy)
            {
                if ((clovek.Jmeno == jmeno) && (clovek.Prijmeni == prijmeni))
                {
                    return clovek;
                }
            }
            return null;
        }
    }
}
