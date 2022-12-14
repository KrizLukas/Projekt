using NovyProjekt;
// instance seznamu pojištěných
SeznamPojistenych seznamPojistenych = new SeznamPojistenych();

char volba = '0';
// hlavní cyklus
while (volba != '4')
{
    seznamPojistenych.VypisUvodniObrazovku();
    volba = Console.ReadKey().KeyChar;
    Console.WriteLine();
    // reakce na volbu
    switch (volba)
    {
        case '1':
            seznamPojistenych.PridejNovehoPojisteneho();
            break;

        case '2':
            seznamPojistenych.VypisVsechnyPojistene();
            break;

        case '3':
            seznamPojistenych.VyhledatPojisteneho();
            break;

        case '4':
            Console.WriteLine("Libovolnou klávesou ukončíte program...");
            break;


        default:
            Console.WriteLine("Neplatná volba, opakujte prosím volbu.");
            break;
    }
    Console.ReadKey();

}

