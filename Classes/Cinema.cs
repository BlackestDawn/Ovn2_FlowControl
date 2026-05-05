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

    public static void UngdomEllerPensionar()
    {
        int alder = FragaEfterNummer("Ange ålder", "Ogiltig ålder.");

        if (alder < 20)
        {
            Console.WriteLine("Ungdomspris: 80kr");
        }
        else if (alder > 64)
        {
            Console.WriteLine("Pensionärspris: 90kr");
        }
        else
        {
            Console.WriteLine("Standardpris: 120kr");
        }
    }

    public static void PrisForSallskap()
    {
        int antal = FragaEfterNummer("Ange antal personer", "Ogiltigt antal personer.", 1);
        int total = 0;

        for (int i = 1; i <= antal; i++)
        {
            int alder = FragaEfterNummer($"Ange ålder för person {i}", "Ogiltig ålder.");

            if (alder < 5 || alder > 100)
            {
                Console.WriteLine($"Person {i}: Gratis");
            }
            else if (alder < 20)
            {
                total += 80;
            }
            else if (alder > 64)
            {
                total += 90;
            }
            else
            {
                total += 120;
            }
        }

        Console.WriteLine($"Antal personer: {antal}");
        Console.WriteLine($"Totalkostnad: {total} kr");
    }
}
