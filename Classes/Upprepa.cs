namespace Ovn2_FlowControl.Classes;

public class Upprepa
{
    public static void TioGanger()
    {
        Console.Write("Skriv en text: ");
        string? text = Console.ReadLine();

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i}. {text} ");
        }

        Console.WriteLine();
    }
}
