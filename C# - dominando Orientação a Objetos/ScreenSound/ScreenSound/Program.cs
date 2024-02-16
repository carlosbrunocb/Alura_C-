using OpenAI_API;
using ScreenSound.Menus;
using ScreenSound.Models;
using OpenAI_API;

//Creating a Chat GPT object
var client = new OpenAIAPI("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");
var chat = client.Chat.CreateConversation(); //start a chat conversation
string response;

Band ira = new Band("Ira");
chat.AppendSystemMessage($"Resuma a banda Ira em 1 parágrafo. Adote um estilo informal.");
response = await chat.GetResponseFromChatbotAsync();
ira.M_Summary = response;
ira.AddRating(new Rating(10));
ira.AddRating(new Rating(9));
ira.AddRating(new Rating(5));
ira.AddAlbum(new Album("MTV ao Vivo 2000"));
ira.AddAlbum(new Album("Psicoacústico"));
ira.AddAlbum(new Album("Isso é Amor"));
ira.AddAlbum(new Album("Clandestino"));

Band beatles = new("The Beatles");
chat.AppendSystemMessage($"Resuma a banda The Beatles em 1 parágrafo. Adote um estilo informal.");
response = await chat.GetResponseFromChatbotAsync();
beatles.M_Summary = response;

Dictionary<string, Band> bandsRegistered = new ();
bandsRegistered.Add("Ira", ira);
bandsRegistered.Add("The Beatles", beatles);

Dictionary<int, Menu> menuOption = new ();
menuOption.Add(1, new MenuRegisterBands());
menuOption.Add(2, new MenuRegisterAlbums());
menuOption.Add(3, new MenuShowBandsLits());
menuOption.Add(4, new MenuAssessBand());
menuOption.Add(5, new MenuAssessAlbum());
menuOption.Add(6, new MenuShowBandsRating());
menuOption.Add(-1, new MenuExit());

void ShowOptionMenu()
{
    Console.WriteLine("\n\n");
    Console.WriteLine("1. To register a band");
    Console.WriteLine("2. To register a album of the band");
    Console.WriteLine("3. To list all band");
    Console.WriteLine("4. To assess a band");
    Console.WriteLine("5. To assess a album of the band");
    Console.WriteLine("6. To show the average rating for a band");
    //Console.WriteLine(". To show the average rating for a band");
    Console.WriteLine("-. To exit enter -1");
    Console.WriteLine("\n");
    Console.Write("# Select an option: ");
    string optionSelected = Console.ReadLine()!;
    int optionNumericSelected = int.Parse(optionSelected);

    if (menuOption.ContainsKey(optionNumericSelected))
    {
        menuOption[optionNumericSelected].Execute(bandsRegistered);

        if (optionNumericSelected != -1) ShowOptionMenu();
    }
    else
    {
        Console.WriteLine($"# Error: {optionSelected} is Invalid Option ");
        Console.WriteLine($"# Error: Returning to menu!");
        Thread.Sleep(2000);
        Console.Clear();
        Menu.ShowLogo();
        ShowOptionMenu();
    }
}

Menu.ShowLogo();
ShowOptionMenu();
