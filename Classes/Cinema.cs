namespace Ovn2_FlowControl.Classes;

public static class Cinema
{
    private static int FragaEfterNummer(
        string promptText,
        string felText = "Ogiltigt värde.",
        int minVarde = 0
    )
    {
        while (true)
        {
            Console.Write($"{promptText}: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int returVal) && returVal >= minVarde)    // Jämför med int.Parse(input) --> "hej" --> Exception
            {
                return returVal;
            }
            else
            {
                Console.WriteLine(felText);
            }
        }
    }

    private static int PrisFranAlder(int alder) =>
        alder switch
        {
            < 5 or > 100 => 0,
            < 20 => 80,
            > 64 => 90,
            _ => 120
        };

    public static void UngdomEllerPensionar()
    {
        int alder = FragaEfterNummer("Ange ålder", "Ogiltig ålder.");
        int pris = PrisFranAlder(alder);

        switch (pris)
        {
            case 0:
                Console.WriteLine("Barn eller Gammelåldringspris: Gratis");
                break;
            case 80:
                Console.WriteLine("Ungdomspris: 80kr");
                break;
            case 90:
                Console.WriteLine("Pensionärspris: 90kr");
                break;
            default:
                Console.WriteLine("Standardpris: 120kr");
                break;
        }
    }

    public static void PrisForSallskap()
    {
        int antal = FragaEfterNummer("Ange antal personer", "Ogiltigt antal personer.", 1);
        int total = 0;

        for (int i = 1; i <= antal; i++)
        {
            int alder = FragaEfterNummer($"Ange ålder för person {i}", "Ogiltig ålder.");
            int pris = PrisFranAlder(alder);
            total += pris;
            if (pris == 0) Console.WriteLine($"Person {i}: Gratis");
        }

        Console.WriteLine($"Antal personer: {antal}");
        Console.WriteLine($"Totalkostnad: {total} kr");
    }
}
