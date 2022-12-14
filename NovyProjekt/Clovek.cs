using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovyProjekt
{
    internal class Clovek
    {   
        public string Jmeno { get; private set; }

        public string Prijmeni { get; private set; }

        public int Vek { get; private set; }

        public string TelefonniCislo { get; private set; }

        public Clovek(string jmeno, string prijmeni, int vek, string telefonniCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefonniCislo = telefonniCislo;
        }

        public override string ToString()
        {
            return String.Format("{0, -10}  {1, -15}  {2, -3}  {3}", Jmeno, Prijmeni, Vek, TelefonniCislo);
        }
    }
}
