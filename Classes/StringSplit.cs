namespace Ovn2_FlowControl.Classes;

public static class StringSplit
{
    public static void DetTredjeOrdet()
    {
        Console.Write("Skriv en mening med minst 3 ord: ");
        string? mening = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(mening))
        {
            Console.WriteLine("Du måste skriva en mening.");
            return;
        }

        string[] ord = mening.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (ord.Length < 3)
        {
            Console.WriteLine("Mening måste innehålla minst 3 ord.");
            return;
        }

        Console.WriteLine($"Det tredje ordet är: {ord[2]}");
    }
}
