using OpenAI_API;
using ScreenSound.Models;
using OpenAI_API;


namespace ScreenSound.Menus;

internal class MenuRegisterBands : Menu
{
    public override void Execute(Dictionary<string, Band> bandsRegistered)
    {
        base.Execute(bandsRegistered);
        ShowOptionTitle("Band Register");
        Console.Write("# Enter the band name: ");
        string bandName = Console.ReadLine()!;
        Band band = new Band(bandName);

        //Creating a Chat GPT object
        var client = new OpenAIAPI("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");
        var chat = client.Chat.CreateConversation(); //start a chat conversation
        chat.AppendSystemMessage($"Resuma a banda {bandName} em 1 parágrafo. Adote um estilo informal.");
        string response = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        band.M_Summary = response;

        bandsRegistered.Add(bandName, band);
        Console.WriteLine($"{bandName} band was successfully registered!");
        Thread.Sleep(2000);
        Console.Clear();

        ShowLogo();
    }
}
