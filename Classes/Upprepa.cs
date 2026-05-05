namespace Ovn2_FlowControl.Classes;

public static class Upprepa
{
    public static void ValtAntalGanger(int antal = 1)
    {
        Console.Write("Skriv en text: ");
        string? text = Console.ReadLine();

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i}. {text} ");
        }

        Console.WriteLine();
    }
    public static void TioGanger()
    {
        ValtAntalGanger(10);
    }
}
