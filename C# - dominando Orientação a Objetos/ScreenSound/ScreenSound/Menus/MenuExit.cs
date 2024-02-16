using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuExit : Menu
{
    public override void Execute(Dictionary<string, Band> bandsRegistered)
    {
        base.Execute(bandsRegistered);
        Console.WriteLine("Closing App. Bye. :)");
    }
}
