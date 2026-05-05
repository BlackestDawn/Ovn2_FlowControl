namespace Ovn2_FlowControl.Classes;

public static class StringSplit
{
    public static void DetPositionsValdaOrdet(int position = 1, string positionsText = "första")
    {
        Console.Write($"Skriv en mening med minst {position} ord: ");
        string? mening = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(mening))
        {
            Console.WriteLine("Du måste skriva en mening.");
            return;
        }

        string[] ord = mening.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (ord.Length < position)
        {
            Console.WriteLine($"Meningen måste innehålla minst {position} ord.");
            return;
        }

        Console.WriteLine($"Det {positionsText} ordet är: {ord[position - 1]}");
    }
    public static void DetTredjeOrdet()
    {
        DetPositionsValdaOrdet(3, "tredje");
    }
}
