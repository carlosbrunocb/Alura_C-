using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuShowBandsRating : Menu
{
    
    public override void Execute(Dictionary<string, Band> bandsRegistered)
    {
        base.Execute(bandsRegistered);
        ShowOptionTitle("Band Rating List");
        string titleTable = "# BANDS";
        string ratingTable = "# RATING";
        string titleAlbum = "@ ALBUMS";
        string assessTable = "@ ASSESSMENT";
        string bandSummary = "@ SUMMARY";


        foreach (var band in bandsRegistered.Keys)
        {
            Console.WriteLine($"{titleTable}{string.Empty.PadLeft(25 - titleTable.Length, ' ')}" +
            $"{ratingTable}");

            double ratingAverage = bandsRegistered[band].M_AverageRating;

            if (ratingAverage > 0)
            {
                Console.WriteLine($"{"| " + band}{string.Empty.PadLeft(23 - band.Length, ' ')}" +
                                  $"{"| " + ratingAverage}");
            }
            else
            {
                Console.WriteLine($"{"| " + band}{string.Empty.PadLeft(23 - band.Length, ' ')}" +
                                  $"{"| -"}");
            }

            Console.WriteLine($"{titleAlbum}{string.Empty.PadLeft(25 - titleAlbum.Length, ' ')}" +
            $"{assessTable}");

            foreach (var album in bandsRegistered[band].Albums)
            {
                double assesssmentAverage = album.M_AverageRating;

                if (assesssmentAverage > 0)
                {
                    Console.WriteLine($"{"| " + album.M_Name}{string.Empty.PadLeft(23 - album.M_Name.Length, ' ')}" +
                                      $"{"| " + assesssmentAverage}");
                }
                else
                {
                    Console.WriteLine($"{"| " + album.M_Name}{string.Empty.PadLeft(23 - album.M_Name.Length, ' ')}" +
                                      $"{"| -"}");
                }
            }
            Console.WriteLine($"{bandSummary}: {bandsRegistered[band].M_Summary}");
            Console.WriteLine();
        }

        Console.WriteLine("\n\n");
        Console.WriteLine("@ Press ANY Key to return to The MENU.");
        Console.ReadKey();
        Console.Clear();

        ShowLogo();
    }
}
