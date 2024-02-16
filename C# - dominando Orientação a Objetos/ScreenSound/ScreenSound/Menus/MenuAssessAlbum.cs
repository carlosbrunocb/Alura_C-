using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuAssessAlbum : Menu
{
    public override void Execute(Dictionary<string, Band> bandsRegistered)
    {
        base.Execute(bandsRegistered);

        ShowOptionTitle("Album Rating");
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
            if (bandsRegistered[bandName].Albums.Count() > 0)
            {
                //int idCount = 1;
                Console.WriteLine("# ALBUMS LIST");

                foreach (var album in bandsRegistered[bandName].Albums)
                {
                    Console.WriteLine($"- {album.M_Name}");
                    //idCount++;
                }

                Console.WriteLine("\n");
                Console.Write("@ Select an album: ");
                string albumName = Console.ReadLine()!;
                //int idAlbum = int.Parse(Console.ReadLine()!) - 1;

                if (bandsRegistered[bandName].Albums.Any(a => a.M_Name.Equals(albumName)))
                {
                    Album album = bandsRegistered[bandName].Albums.First(a => a.M_Name.Equals(albumName));
                    Console.Write($"Your rating for album {album.M_Name}: ");
                    Rating albumRating = Rating.Parse(Console.ReadLine()!);
                    album.AddRating(albumRating);
                    Console.WriteLine($"\n$ The rating {albumRating.M_Score} was added successfully to Album " +
                        $"{album.M_Name} of the band {bandName}!");
                    Console.WriteLine("$ Returning to Menu. :D");
                } 
                else
                {
                    Console.WriteLine($"$ The Album {albumName} not found for the band {bandName}!");
                    Console.WriteLine("$ Returning to Menu. :(");
                }

                //Console.Write($"Your rating for album " +
                //    $"{bandsRegistered[bandName].Albums[idAlbum].M_Name}: ");
                //Rating albumRating = Rating.Parse(Console.ReadLine()!);
                //bandsRegistered[bandName].Albums[idAlbum].AddRating(albumRating);
                //Console.WriteLine($"\n$ The rating {albumRating.M_Score} was added successfully to Album " +
                //    $"{bandsRegistered[bandName].Albums[idAlbum].M_Name} of the band {bandName}!");
                //Console.WriteLine("$ Returning to Menu. :D");
            }
            //Console.WriteLine("\n");
            //Console.Write("@ Enter an album: ");
            //string albumName = Console.ReadLine()!;

            //if (bandsRegistered[bandName].Albums.Any(a => a.M_Name.Equals(albumName)))
            //{
            //    Album album = bandsRegistered[bandName].Albums.First(a => a.M_Name.Equals(albumName));
            //    Console.Write($"Your rating for album {album.M_Name}: ");
            //    Rating albumRating = Rating.Parse(Console.ReadLine()!);
            //    album.AddRating(albumRating);
            //    Console.WriteLine($"\n$ The rating {albumRating.M_Score} was added successfully to Album " +
            //        $"{album.M_Name} of the band {bandName}!");
            //    Console.WriteLine("$ Returning to Menu. :D");
            //}
            else
            {
                Console.WriteLine($"$ There is not album available for the band {bandName}");
                Console.WriteLine("$ Returning to Menu. :(");
            }
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
