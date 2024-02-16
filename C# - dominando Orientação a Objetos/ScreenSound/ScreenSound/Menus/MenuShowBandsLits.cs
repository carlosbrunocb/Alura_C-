using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuShowBandsLits : Menu
{
    public override void Execute(Dictionary<string, Band> bandsRegistered)
    {
        base.Execute(bandsRegistered);
        ShowOptionTitle("Showing all registered bands");

        Console.WriteLine("#  BANDS");

        int index = 1;

        foreach (var band in bandsRegistered.Keys)
        {
            Console.WriteLine($"{index}. {band}");
            index++;
        }

        Console.WriteLine("\n\n");
        Console.WriteLine("@ Press ANY Key to return to The MENU.");
        Console.ReadKey();
        Console.Clear();

        ShowLogo();
    }
}
