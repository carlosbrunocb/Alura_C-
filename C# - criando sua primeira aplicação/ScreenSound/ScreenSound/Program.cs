// Screen Sound

//string welcomeMessage = "Welcome to Screen Sound";



using System;
using System.Linq;

string welcomeMessage = "Welcome to";
//List<string> bandsList = new List<string>();
//List<string> bandsList = new List<string> {"U2", "The Beatles", "Calypso"};

Dictionary<string, List<int>> bandsRegistered = new Dictionary<string, List<int>>();
bandsRegistered.Add("Link Park", new List<int> {10, 9, 5});  
bandsRegistered.Add("The Beatles", new List<int> ());  

const int sharpNumberAdjustment = 4;



void ShowLogo()
{
    Console.WriteLine(welcomeMessage);
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    
    //Console.WriteLine("###########################");
    //Console.WriteLine($"# {welcomeMessage} #");
    //Console.WriteLine("###########################");

}

void ShowOptionMenu()
{
    Console.WriteLine("\n\n");
    Console.WriteLine("1. To register a band");
    Console.WriteLine("2. To list all band");
    Console.WriteLine("3. To assess a band");
    Console.WriteLine("4. To show the average rating for a band");
    Console.WriteLine("-. To exit enter -1");
    Console.WriteLine("\n");
    Console.Write("# Select an option: ");
    string optionSelected = Console.ReadLine()!;
    int optionNumericSelected = int.Parse(optionSelected);

    //if (optionNumericSelected == 1)
    //{
    //    Console.WriteLine($"You entered option {optionSelected}");
    //}

    switch (optionNumericSelected)
    {
        case 1:
            //Console.WriteLine($"You entered option {optionSelected}");
            RegisterBands();
            break;

        case 2:
            //Console.WriteLine($"You entered option {optionSelected}");
            ShowBandsLits();
            break;

        case 3:
            //Console.WriteLine($"You entered option {optionSelected}");
            AssessBand();
            break;

        case 4:
            Console.WriteLine($"You entered option {optionSelected}");
            ShowBandsRating();
            break;

        case -1:
            Console.WriteLine("Closing App. Bye. :)");
            break;

        default:
            Console.WriteLine($"# Error: {optionSelected} is Invalid Option ");
            Console.WriteLine($"# Error: Returning to menu!");
            //Console.WriteLine("Press enter to return to the menu.");
            //Console.ReadLine();
            Thread.Sleep(2000);
            Console.Clear();
            ShowLogo();
            ShowOptionMenu();
            break;
    }
}

void ShowBandsRating()
{
    Console.Clear();
    ShowOptionTitle("Band Rating List");
    string titleTable = "# BANDS";
    string ratingTable = "# RATING";


    Console.WriteLine($"{titleTable}{string.Empty.PadLeft(25 - titleTable.Length, ' ')}" +
        $"{ratingTable}");

    foreach (var band in bandsRegistered.Keys)
    {
        if(bandsRegistered[band].Any())
        {
            
            double ratingAverage = bandsRegistered[band].Average();
            Console.WriteLine($"{"| " + band}{string.Empty.PadLeft(23 - band.Length, ' ')}" +
        $"{"| " + ratingAverage}");
        } else
        {
            Console.WriteLine($"{"| " + band}{string.Empty.PadLeft(23 - band.Length, ' ')}" +
        $"{"| -"}");
        }           
    }

    Console.WriteLine("\n\n");
    Console.WriteLine("@ Press ANY Key to return to The MENU.");
    Console.ReadKey();
    Console.Clear();
    ShowLogo();
    ShowOptionMenu();

}

void AssessBand()
{
    Console.Clear();
    ShowOptionTitle("Band Rating");
    Console.WriteLine("# BANDS LIST");

    foreach (var band in bandsRegistered.Keys)
    {
        Console.WriteLine($"* {band}");
    }

    Console.WriteLine("\n");
    Console.Write("@ Enter name of the band to be assessed: ");
    string bandName = Console.ReadLine()!;

    if(bandsRegistered.ContainsKey(bandName))
    {
        Console.Write("Your rating: ");
        int bandRating = int.Parse(Console.ReadLine()!);
        bandsRegistered[bandName].Add(bandRating);
        Console.WriteLine("\n$ Rating added successfully!");
        Console.WriteLine("$ Returning to Menu. :D");

    } else {
        Console.WriteLine("$ Band not found or not registered!");
        Console.WriteLine("$ Returning to Menu. :(");
    }

    Thread.Sleep(2000);
    Console.Clear();
    ShowLogo();
    ShowOptionMenu();
}

void ShowBandsLits()
{
    Console.Clear();
    //Console.WriteLine("################################");
    //Console.WriteLine("# Showing all registered bands #");
    //Console.WriteLine("################################");
    ShowOptionTitle("Showing all registered bands");

    //Console.WriteLine("\n");
    Console.WriteLine("#  BANDS");

    int index = 1;

    //for (int i = 0; i < bandsList.Count; i++)
    //{
    //Console.WriteLine($"{index}. {bandsList[i]}");
    //}

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
    ShowOptionMenu();
}

void RegisterBands()
{
    Console.Clear();
    ShowOptionTitle("Band Register");
    //Console.WriteLine("@ Band Register");
    Console.Write("# Enter the band name: ");
    string bandName = Console.ReadLine()!;
    //bandsList.Add(bandName);
    bandsRegistered.Add(bandName, new List<int>());
    Console.WriteLine($"{bandName} band was successfully registered!");
    Thread.Sleep(2000);
    Console.Clear();
    ShowLogo();
    ShowOptionMenu();
}

void ShowOptionTitle(string title)
{
    int numberSymbols = title.Length + sharpNumberAdjustment;
    string numberAsterisk = string.Empty.PadLeft(numberSymbols, '#');

    Console.WriteLine(numberAsterisk);
    Console.WriteLine($"# {title} #");
    Console.WriteLine(numberAsterisk);
    Console.WriteLine("\n");
}

ShowLogo();
ShowOptionMenu();

//Console.WriteLine(welcomeMessage);

