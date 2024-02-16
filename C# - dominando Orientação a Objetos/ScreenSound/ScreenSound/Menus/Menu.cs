using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class Menu
{
    private const int sharpNumberAdjustment = 4;
    private const string welcomeMessage = "Welcome to";
    public static void ShowLogo()
    {
        Console.WriteLine(welcomeMessage);
        Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    }

    public void ShowOptionTitle(string title)
    {
        int numberSymbols = title.Length + sharpNumberAdjustment;
        string numberAsterisk = string.Empty.PadLeft(numberSymbols, '#');

        Console.WriteLine(numberAsterisk);
        Console.WriteLine($"# {title} #");
        Console.WriteLine(numberAsterisk);
        Console.WriteLine("\n");
    }

    public virtual void Execute(Dictionary<string, Band> bandsRegistered)
    {
        Console.Clear();
    }

}
