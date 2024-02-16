using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRegisterAlbums : Menu
{
    public override void Execute(Dictionary<string, Band> bandsRegistered)
    {
        base.Execute(bandsRegistered);
        ShowOptionTitle("Album Register");
        Console.Write("# Enter the band name of album to be registered: ");
        string bandName = Console.ReadLine()!;

        if (bandsRegistered.ContainsKey(bandName))
        {
            Console.WriteLine("Now, enter the album title:");
            string titleAlbum = Console.ReadLine()!;
            bandsRegistered[bandName].AddAlbum(new Album(titleAlbum));
            Console.WriteLine($"The {titleAlbum} album of the {bandName} band was successfully registered!");
        }
        else
        {
            Console.WriteLine($"$ The {bandName} band not found or not registered!");
            Console.WriteLine("$ Returning to Menu. :(");
        }


        Thread.Sleep(2000);
        Console.Clear();

        ShowLogo();
    }
}
