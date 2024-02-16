using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuAssessBand : Menu
{

    public override void Execute(Dictionary<string, Band> bandsRegistered)
    {
        base.Execute(bandsRegistered);   
        ShowOptionTitle("Band Rating");
        Console.WriteLine("# BANDS LIST");

        foreach (var band in bandsRegistered.Keys)
        {
            Console.WriteLine($"* {band}");
        }

        Console.WriteLine("\n");
        Console.Write("@ Enter name of the band to be assessed: ");
        string bandName = Console.ReadLine()!;

        if (bandsRegistered.ContainsKey(bandName))
        {
            Console.Write("Your rating: ");
            Rating bandRating = Rating.Parse(Console.ReadLine()!);
            bandsRegistered[bandName].AddRating(bandRating);
            Console.WriteLine("\n$ Rating added successfully!");
            Console.WriteLine("$ Returning to Menu. :D");

        }
        else
        {
            Console.WriteLine("$ Band not found or not registered!");
            Console.WriteLine("$ Returning to Menu. :(");
        }

        Thread.Sleep(2000);
        Console.Clear();

        ShowLogo();
    }
}
